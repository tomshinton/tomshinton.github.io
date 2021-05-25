function Embed()
{
    let outerBlogbox = document.currentScript.parentElement;

     fetch(blogURL).then(response => response.text()).then(data =>
    {
        let Parser = new DOMParser();
        let xml = Parser.parseFromString(data, "application/xml");
        let posts = xml.getElementsByTagName('post');

        console.log(outerBlogbox);
        for(let postURL = 0; postURL < postURLS.length; ++postURL )
        {              
            for(let i = 0; i < posts.length; ++i)
            {
                let currPost = posts[i];

                if(currPost.getElementsByTagName('postURL')[0].innerHTML == postURLS[postURL])
                {
                    buildPost(currPost, outerBlogbox);
                }
            }
        }
    });
}

function buildPost(currPost, outerBox)
{
    console.log("Building post");

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
    outerBox.appendChild(blogAnchor);
}

Embed();