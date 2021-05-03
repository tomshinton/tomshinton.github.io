let publishedGamesUrl = "/assets/data/xml/publishedGames.xml";
let blogListUrl= "/assets/content/blog/TestBlog.html";

function FindBlogPosts() 
{
    fetch(blogListUrl).then(response => response.text()).then(data =>
    {
        let Parser = new DOMParser();
        let html = Parser.parseFromString(data, "text/html");

        console.log(html.getElementsByTagName('meta')[0].content);
    });
}

function BuildHomePage() 
{
    fetch(publishedGamesUrl).then(response => response.text()).then(data =>
    {
        let Parser = new DOMParser();
        let xml = Parser.parseFromString(data, "application/xml");

        var mainBody = document.getElementById("main");

        let games = xml.getElementsByTagName('game');
        console.log("Found " + games.length + " games in Published Games xml");

        if (games.length > 0) 
        {
            console.log("Building homepage");

            for (let i = 0; i < games.length; ++i) 
            {
                //Create new Card
                let newCard = document.createElement("div");
                newCard.className = "card";

                //Create Image
                let bannerImage = document.createElement("img");
                bannerImage.src = games[i].getElementsByTagName('bannerUrl')[0].innerHTML;
                bannerImage.className = "gameBanner"
                newCard.appendChild(bannerImage);

                //Create inner text and fading section
                let bannerMiddle = document.createElement("div");
                bannerMiddle.className = "gameBannerMiddle";

                let bannerTextName = document.createElement("div");
                bannerTextName.className = "gameBannerText";
                bannerTextName.textContent = games[i].getElementsByTagName('name')[0].innerHTML;
                bannerMiddle.appendChild(bannerTextName);

                let bannerTextdeveloper = document.createElement("div");
                bannerTextdeveloper.className = "gameBannerTextMinor";
                bannerTextdeveloper.textContent = games[i].getElementsByTagName('developer')[0].innerHTML;
                bannerMiddle.appendChild(bannerTextdeveloper);

                let bannerTextRole = document.createElement("div");
                bannerTextRole.className = "gameBannerTextMinor";
                bannerTextRole.textContent = games[i].getElementsByTagName('role')[0].innerHTML;
                bannerMiddle.appendChild(bannerTextRole);
                
                let bannerTextPlatform = document.createElement("div");
                bannerTextPlatform.className = "gameBannerTextMinor";
                bannerTextPlatform.textContent = games[i].getElementsByTagName('platforms')[0].innerHTML;
                bannerMiddle.appendChild(bannerTextPlatform);

                newCard.appendChild(bannerMiddle);
                mainBody.appendChild(newCard);
            }
        }
    });
}

BuildHomePage();
FindBlogPosts();