/* 
Template for BlogCard

<div class=blogBox id=blogBox>
<div class=blogCard>
<img class=blogThumbnail src="/assets/images/blog/thumbnails/defaultThumbnail.png">
<div class=blogTitle>FTransform Equivalence</div>
</div>
</div> */

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

                    console.log(catArr);
                    if(catArr.length > 0)
                    {
                        let categoriesBox = document.createElement("div");
                        categoriesBox.className = "blogCategories";
                        
                        console.log("Adding " + catArr.length + " categories for post " + currPost.getElementsByTagName('title')[0].innerHTML);
                        for(let i = 0; i < catArr.length; ++i)
                        {
                            let category = catArr[i].innerHTML;
                            console.log(category);

                            let newCategory = document.createElement("div");
                            newCategory.className = "blogCategory";

                            newCategory.textContent = catArr[i].innerHTML;
                            categoriesBox.appendChild(newCategory);
                        }
                        
                        blogCard.appendChild(categoriesBox);
                    }

                    //push new card to container
                    newBlogBox.appendChild(blogAnchor);
                }

                mainBody.appendChild(newBlogBox);
            }
        });
    }
}

BuildBlog();