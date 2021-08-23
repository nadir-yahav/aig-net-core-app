using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "Category", "Description", "Image", "Title" },
                values: new object[,]
                {
                    { 1, "business", "Minister of Finance Israel Katz is forming a new plan as the unpaid leave payments are due to be cut next month.", "https://images.globes.co.il/images/NewGlobes/big_image_800/2018/9CAD617B01EF4A842E7F9751814216FD_800x392.20181108T181028.jpg", "Unemployment in Israel falls to 8%" },
                    { 23, "technology", "The ProWritingAid Lifetime Subscription Bundle includes an app that gives you stylistic advice.", "https://s.yimg.com/os/creatr-uploaded-images/2021-06/30f74ac0-c3b2-11eb-9fef-1179789fe80c", "Improve your writing with this award-winning productivity software package" },
                    { 22, "technology", "Apple and Epic Games, maker of the wildly popular game Fortnite, square off on Monday in a trial that could decide how much control Apple can exert over the app economy.", "https://static01.nyt.com/images/2021/04/29/business/29epicapple/01epicapple-moth.jpg", "Apple and Epic Head to Court Over Their Slices of the App Pie" },
                    { 21, "technology", "The company tells Apple users that tracking helps keep those platforms “free of charge,” but opting out now doesn't mean paying up later.", "https://media.wired.com/photos/60904bed68d4596874a4fd14/master/pass/Sec_Facebook_2CK6JT6.jpg", "Don’t Buy Into Facebook’s Ad-Tracking Pressure on iOS 14.5" },
                    { 20, "health", "Over half of parents surveyed in a national poll said it was unlikely their child would receive a COVID-19 vaccine should the shots see expanded authorization in younger age groups.", "https://static.foxnews.com/foxnews.com/content/uploads/2021/07/5822b8b8-child_vaccine_istock.jpg", "Parents split on COVID-19 vaccine for young kids, poll finds" },
                    { 19, "health", "Más de mil millones de mujeres de todo el mundo habrán experimentado la perimenopausia para 2025, pero aún no tenemos una cultura para saber más al respecto.", "https://static01.nyt.com/images/2021/04/27/well/27Well-perimenopause-esp-1/27Well-perimenopause-moth.jpg", "‘Nadie me dijo que sería así’: la perimenopausia sigue siendo un misterio" },
                    { 18, "health", "Desglosamos los signos, causas y tratamientos para cinco de los síntomas más comunes de estas etapas.", "https://static01.nyt.com/images/2021/04/27/well/27Well-sidebar-top/27Well-sidebar-top-moth.jpg", "Perimenopausia: síntomas, causas y tratamientos" },
                    { 17, "health", "India's government faced calls for a strict lockdown to slow a devastating surge in new coronavirus cases, and a court in New Delhi on Wednesday will decide whether to punish officials for failing to end a 2-week-old erratic supply of oxygen to overstretched hospitals.", "https://static.foxnews.com/foxnews.com/content/uploads/2021/05/INDIA_COVID_CRISIS_AP.jpg", "Indian government faces coronavirus lockdown calls, contempt charges" },
                    { 16, "health", "The U.S. Food and Drug Administration is expected to authorize Pfizer’s COVID-19 vaccine for young adults age 12 and older by next week, according to a federal official and a person familiar with the process, setting up shots for many before the beginning of the next school year.", "https://static.foxnews.com/foxnews.com/content/uploads/2020/05/iStock-1127763296.jpg", "FDA expected to OK Pfizer vaccine for teens within week" },
                    { 15, "science", "As millions around the globe desperately seek coronavirus vaccines, Israel's transportation and tourism ministries are hoping to find ways to open the economy and the tourism industry", "https://www.haaretz.com/polopoly_fs/1.9791083.1620655369!/image/1805404839.jpg_gen/derivatives/landscape_108/1805404839.jpg", "COVID and Israel: country wants to sell its vaccines to a luxury cruise line" },
                    { 14, "science", "Work performed by non-medical staff has ground to a halt, but facilities such as emergency rooms, oncology departments, dialysis, maternity and premature infant wards are functioning normally", "https://www.haaretz.com/polopoly_fs/1.9999760.1626268427!/image/2988996833.jpg_gen/derivatives/landscape_108/2988996833.jpg", "Garbage overflows, surgeries delayed: support staff strike in hospitals takes its toll" },
                    { 24, "technology", "The update has been a long time coming, and if you haven't played, now's the time. We asked Robert Kurvitz, the game's designer, if he’s finally satisfied with it.", "https://media.wired.com/photos/60ba714770d107b3e767d59e/master/pass/games_disco-elysium.jpg", "The Incredible, Absurd World of Disco Elysium: The Final Cut" },
                    { 13, "science", "In Europe, raw pet food turned out to be laden with antibiotic-resistant bacteria; in Israel, such fripperies are banned outright", "https://www.haaretz.com/polopoly_fs/1.9995083.1626158448!/image/3836504835.jpg_gen/derivatives/landscape_108/3836504835.jpg", "Raw dog foods are a superbug hazard, researchers warn" },
                    { 11, "science", "Paleontologists found the pierced skull of a cave bear in a Siberian cave. It could have been caused naturally – or may have been made for ritual purposes", "https://www.haaretz.com/polopoly_fs/1.9885374.1623156981!/image/3923841999.jpg_gen/derivatives/landscape_108/3923841999.jpg", "Case closed: 35,000-year-old murder of a bear finally solved" },
                    { 10, "entertainment", "The current round of fighting ignited a virtual powder keg, with developers and gamers slamming Israel fiercely. Even the veteran gaming site IGN was caught up in the fray", "https://www.haaretz.com/polopoly_fs/1.9827711.1621516720!/image/2449330690.jpg_gen/derivatives/landscape_108/2449330690.jpg", "Israel is losing on a new front: The gaming world" },
                    { 9, "entertainment", "Rapper Sameh 'Saz' Zakout and Uriya Rosenman tackle racism in Israel in video produced as part of project promoting dialogue between Arabs and Jews", "https://www.haaretz.com/polopoly_fs/1.9828844.1621536237!/image/748109202.png_gen/derivatives/landscape_108/748109202.png", "A Jew and an Arab confront Israeli prejudice in ‘I’m Not Racist’ reimagining" },
                    { 8, "entertainment", "The modern Jewish holiday may be synonymous with cheesecake, cheese platters and other dairy-based products, but Shavuot meals in the Middle East and North Africa were far meatier affairs", "https://www.haaretz.com/polopoly_fs/1.9809270.1620997461!/image/2522396801.jpg_gen/derivatives/landscape_108/2522396801.jpg", "Preparing for a nondairy Shavuot, just like some Jews have done for centuries" },
                    { 7, "entertainment", "Educators at this unique Jaffa school – where 40 percent of the pupils are Arab – found new ways to defuse tensions, fear and harsh rhetoric between the pupils", "https://www.haaretz.com/polopoly_fs/1.9878672.1623053744!/image/1031031464.jpg_gen/derivatives/landscape_108/1031031464.jpg", "What it's like studying in an Arab-Jewish school during a war" },
                    { 6, "entertainment", "Photographer Yehoshua Shuka Glotman documented the joyous scenes at the Rashbi’s tomb for almost 40 years, captivated by the atmosphere there. A new book showcases his images from the annual events, prior to last week’s tragedy", "https://www.haaretz.com/polopoly_fs/1.9766723.1619960630!/image/2697928942.jpg_gen/derivatives/landscape_108/2697928942.jpg", "In photos: Mount Meron celebration over the years" },
                    { 5, "business", "The cumulative deficit for the twelve months to the end of May was NIS 149.2 billion, or 10.5% of GDP.", "https://res.cloudinary.com/globes/image/upload/t_desktop_article_content_header_800*392/v1596469388/old/1666917.jpg", "Israel's fiscal deficit narrows as gov't revenues rise" },
                    { 4, "business", "With El Al competing with Delta, United and American Airlines this summer, there will be 10 daily flights alone between Tel Aviv and New York.", "https://images.globes.co.il/images/NewGlobes/big_image_800/2020/800x392.2020618T135158.jpg", "El Al adding flights on Tel Aviv - US routes" },
                    { 3, "business", "The Israeli e-commerce company has developed a platform that allows communication with buyers in 25 languages and purchases in more than 100 currencies while calculating local sales taxes.", "https://images.globes.co.il/Images/NewGlobes/big_image/2014/c28_stock-575.jpg", "Global-E files for Nasdaq IPO at $3.5b valuation" },
                    { 2, "business", "The Israeli web behavior and traffic analytics company's founder and CEO Or Offer will sell shares worth $10 million.", "https://res.cloudinary.com/globes/image/upload/t_desktop_article_content_header_800*392/v1603799749/COT_Pic/%D7%90%D7%95%D7%A8_%D7%A2%D7%95%D7%A4%D7%A8_%D7%A7%D7%A8%D7%99%D7%98_-_%D7%A8%D7%95%D7%AA%D7%9D_%D7%9B%D7%A0%D7%A2%D7%A0%D7%99_pl9zyo.jpg", "Similarweb files to raise $150m on NYSE at $1.5b valuation" },
                    { 12, "science", "The stretch found in Jerusalem’s City of David ends the dispute about whether previously unearthed structures were part of the city wall, but doesn’t help elucidate who exactly built it or why", "https://www.haaretz.com/polopoly_fs/1.9998937.1626261788!/image/3470578436.jpg_gen/derivatives/landscape_108/3470578436.jpg", "Israeli archaeologists find new section of Jerusalem’s ancient defensive wall" },
                    { 25, "technology", "It’s been almost a decade since Leon Panetta, then the secretary of defense, warned of an impending “Cyber Pearl Harbor.” He didn’t want to be right.", "https://static01.nyt.com/images/2021/06/05/business/05cyber-pearlharbor1/05cyber-pearlharbor1-moth.jpg", "Are We Waiting for Everyone to Get Hacked?" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articles");
        }
    }
}
