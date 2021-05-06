/* 
Template for BlogCard

<div class=blogBox id=blogBox>
<div class=blogCard>
<img class=blogThumbnail src="/assets/images/blog/thumbnails/defaultThumbnail.png">
<div class=blogTitle>FTransform Equivalence</div>
</div>
</div> */

let blogPosts = [];

let inputDiv = document.createElement("input");
inputDiv.addEventListener('change', filterPosts);
inputDiv.className = "blogBoxSearch";
inputDiv.placeholder = "Search";
inputDiv.spellcheck = false;

let noPostsFoundDiv = document.createElement("div");
noPostsFoundDiv.textContent = "There's nothing here, chief";
noPostsFoundDiv.style.display = "none";

function BuildBlog()
{
    if(typeof sourceBlogXML == 'undefined')
    {
         alert("Could not source sourceBlogXML - make sure to define it in a seperate script blog above this JS implementation")
    }
    else
    {
        console.log("Building blog in page, sourced from " + sourceBlogXML);

        fetch(sourceBlogXML).then(response => response.text()).then(data =>
        {
            let Parser = new DOMParser();
            let xml = Parser.parseFromString(data, "application/xml");
        
            var mainBody = document.getElementById("main");
        
            let posts = xml.getElementsByTagName('post');

            if(posts.length > 0)
            {
                console.log("Found " + posts.length + " post(s) - building");

                //Main box
                let newBlogBox = document.createElement("div");
                newBlogBox.className = "blogBox";
                newBlogBox.id = "blogBox";
                
                newBlogBox.appendChild(inputDiv);

                let newblogCardContainer = document.createElement("div");
                newblogCardContainer.className = "blogCardContainer"
                newblogCardContainer.appendChild(noPostsFoundDiv);

                newBlogBox.appendChild(newblogCardContainer);
                
                //forloop over posts and add to blogbox
                for (let i = 0; i < posts.length; ++i) 
                {
                    let currPost = posts[i];
                 
                    //create anchor for card
                    let blogURLLiteral = currPost.getElementsByTagName('postURL')[0].innerHTML;
                    var blogAnchor = document.createElement('a');
                    blogAnchor.className = "blogCard";
                    blogAnchor.setAttribute('href', blogURLLiteral);

                    //Create card
                    let blogCard = document.createElement("div");
                    blogAnchor.appendChild(blogCard);

                    //create card image
                    let postImage = document.createElement("img");
                    postImage.className = "blogThumbnail";

                    let postThumbnail = currPost.getElementsByTagName('postThumbnail')[0].innerHTML;
                    postImage.alt = "Blog Image";

                    if(postThumbnail == "")
                    {
                        postImage.src = "/assets/images/blog/thumbnails/defaultThumbnail.png";
                    }
                    else
                    {
                        postImage.src = postThumbnail;
                    }

                    blogCard.appendChild(postImage);

                    //Add title
                    let postTitle = document.createElement("div");
                    postTitle.className = "blogTitle";
                    postTitle.textContent = currPost.getElementsByTagName('title')[0].innerHTML;               
                    blogCard.appendChild(postTitle);

                    //add Categories alphabetically - cooerce into an array first before sort.  This is a HTMLCollection by default
                    let catArr = [].slice.call(currPost.getElementsByTagName('category')).sort(function(a, b){
                        return a.textContent.localeCompare(b.textContent);
                    });

                    if(catArr.length > 0)
                    {
                        let categoriesBox = document.createElement("div");
                        categoriesBox.className = "blogCategories";
                        categoriesBox.id = "blogCategories";

                        for(let i = 0; i < catArr.length; ++i)
                        {
                            let category = catArr[i].innerHTML;
                            let newCategory = document.createElement("div");
                            newCategory.className = "blogCategory";
                            newCategory.id = "blogCategory";

                            newCategory.textContent = catArr[i].innerHTML;
                            categoriesBox.appendChild(newCategory);
                        }
                        
                        blogCard.appendChild(categoriesBox);
                    }

                    //push new card to container
                    newblogCardContainer.appendChild(blogAnchor);
                    blogPosts.push(blogAnchor);
                }

                mainBody.appendChild(newBlogBox);
            }
        });
    }
}

function filterPosts()
{
    let filter = inputDiv.value;
    let matchingPosts = 0;

    if(filter != "")
    {
        for(let i = 0; i < blogPosts.length; ++i)
        {
            let currPost = blogPosts[i];

            if(!postMatchesFilter(currPost, inputDiv.value))
            {
                currPost.style.display = "none";
            }
            else
            {
                currPost.style.display = "inline";
                matchingPosts++;
            }

            if(matchingPosts == 0)
            {
                noPostsFoundDiv.style.display = "inline";
            }
            else
            {
                noPostsFoundDiv.style.display = "none";
            }
        }
    }
    else
    {
        noPostsFoundDiv.style.display = "none";

        for(let i = 0; i < blogPosts.length; ++i)
        {
            blogPosts[i].style.display = 'inline';
        }
    }
}

function postMatchesFilter(inPost, inFilter)
{
    let parsedFilter = inFilter.split(" ");

    let nameMatch = false;
    let categoryMatch = false;
    
    //match name
    let postInner = inPost.childNodes[0];
    let blogTitle = postInner.querySelectorAll(".blogTitle");
    let parsedName = blogTitle[0].textContent.split(" ");
    
    for(let i = 0; i < parsedFilter.length; ++i)
    {
        let currentPhrase = parsedFilter[i].toUpperCase();
        for(let j = 0; j < parsedName.length; j++)
        {
            let currentName = parsedName[j].toUpperCase();

            if(currentName.indexOf(currentPhrase) > -1)
            {
                nameMatch = true;
                break;
            }
        }
    }
        
    //match categories
    let blogCategories = postInner.querySelectorAll(".blogCategory");
    let parsedCategories = [];
    for(let i = 0; i < blogCategories.length; ++i)
    {
        let parsedCategory = blogCategories[i].innerText.split(" ");
        for(let j = 0; j < parsedCategory.length; ++j)
        {
            parsedCategories.push(parsedCategory[j]);
        }
    }

    for(let i = 0; i < parsedFilter.length; ++i)
    {
        let currentPhrase = parsedFilter[i].toUpperCase();
        for(let j = 0; j < parsedCategories.length; j++)
        {
            let currentName = parsedCategories[j].toUpperCase();

            if(currentName.indexOf(currentPhrase) > -1)
            {
                categoryMatch = true;
                break;
            }
        }
    }

    return categoryMatch || nameMatch;
}

BuildBlog();