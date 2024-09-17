using MauiApp1.Models;
namespace MauiApp1.Services
{
    internal class PlanetsService
    {
        private static List<Planet> planets = new()
        {
            new()
            {
                Name = "Mercury",
                Subtitle = "The smallest planet",
                HeroImage = "mercury.png",
                Description = "Mercury is the first planet from the Sun and the smallest in the Solar System. In English, it is named after the ancient Roman god Mercurius (Mercury), god of commerce and communication, and the messenger of the gods. ",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://cdn.theatlantic.com/thumbor/D15rQggf6357X1-u6VpTD2N1yQE=/0x27:1041x613/976x549/media/img/mt/2017/04/MercuryImage/original.jpg",
                    "https://cdn.mos.cms.futurecdn.net/fjbeeRiPRQjQNhizwy7cWX-1200-80.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4a/Mercury_in_true_color.jpg/290px-Mercury_in_true_color.jpg"
                }
            },
            new()
            {
                Name = "Venus",
                Subtitle = "The pressure cooker",
                HeroImage = "venus.png",
                Description = "Of all the planets, Venus is the one most similar to Earth. In fact, Venus is often called Earth's “sister” planet. As similar as it is in some ways, however, it is also very different in others. ",
                AccentColorStart = Color.FromArgb("#a6393b"),
                AccentColorEnd = Color.FromArgb("#d17f21"),
                Images = new()
                {
                    "https://science.nasa.gov/wp-content/uploads/2023/06/Venus-jpeg.webp?w=4096&format=png&crop=1",
                    "https://cdn.mos.cms.futurecdn.net/RifjtkFLBEFgzkZqWEh69P.jpg"
                }
            },
            new()
            {
                Name = "Earth",
                Subtitle = "The cradle of life",
                HeroImage = "earth.png",
                Description = "The Earth is the only planet known where life exists. Almost 1.5 million species of animals and plants have been discovered so far, and many more have yet to be found. While other planets may have small amounts of ice or steam, the Earth is 2/3 water. Earth has perfect conditions for a breathable atmosphere. ",
                AccentColorStart = Color.FromArgb("#0e3d68"),
                AccentColorEnd = Color.FromArgb("#2e97c7"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cb/The_Blue_Marble_%28remastered%29.jpg/1200px-The_Blue_Marble_%28remastered%29.jpg",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT-cytURmCgsA4fJGctrb9vWELVJwM1keEC4Q&s",
                    "https://images.newscientist.com/wp-content/uploads/2019/09/09162708/iss048-e-2035_lrg.jpg?width=778"
                }
            },
            new()
            {
                Name = "Mars",
                Subtitle = "The red beauty",
                HeroImage = "mars.png",
                Description = "No planet has sparked the imaginations of humans as much as Mars. It may be the reddish color of Mars, or the fact that it can often be easily seen in the night sky, that has caused people to wonder about this close neighbor of ours. Tales of “Martians” invading Earth have been around for well over fifty years. But is it likely that any kind of life really does exist on Mars? ",
                AccentColorStart = Color.FromArgb("#a23036"),
                AccentColorEnd = Color.FromArgb("#eb3333"),
                Images = new()
                {
                    "https://researchfdi.com/wp-content/uploads/2021/10/8944_1-PIA24546-1280.jpeg",
                    "https://www.worldatlas.com/r/w1300-q80/upload/bb/c3/32/shutterstock-1041249343.jpg",
                    "https://www.openaccessgovernment.org/wp-content/uploads/2021/04/dreamstime_xxl_121672573-scaled.jpg"
                }
            },

             new()
            {
                Name = "Jupiter",
                Subtitle = " The gas giant",
                HeroImage = "jupiter.png",
                Description = "Jupiter is the fifth planet from the Sun and the largest in the Solar System. " +
                "It is a gas giant with a mass more than two and a half times that of all the other planets in" +
                " the Solar System combined, and slightly less than one one-thousandth the mass of the Sun. Jupiter" +
                " orbits the Sun at a distance of 5.20 AU (778.5 Gm) with an orbital period of 11.86 years. Jupiter " +
                "is the third brightest natural object in the Earth's night sky after the Moon and Venus, and it has" +
                " been observed since prehistoric times. It was named after Jupiter, the chief deity of ancient Roman religion. ",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#cd8026"),
                Images = new()
                {
                    "https://c02.purpledshub.com/uploads/sites/41/2024/04/jupiter.jpg?w=1200",
                    "https://cdn.britannica.com/66/155966-131-17B5B518/Jupiter.jpg"
                }

            },

              new()
            {
                Name = "Saturn",
                Subtitle = " The ring planet",
                HeroImage = "saturn.png",
                Description = "Saturn is the sixth planet from the Sun and the second-largest in the Solar System," +
                " after Jupiter. It is a gas giant with an average radius of about nine-and-a-half times that of Earth. " +
                "It has only one-eighth the average density of Earth, but is over 95 times more massive.",
                AccentColorStart = Color.FromArgb("#996237"),
                AccentColorEnd = Color.FromArgb("#c6502f"),
                Images = new()
                {
                    "https://cf-img-a-in.tosshub.com/sites/visualstory/wp/2024/06/Saturn1.jpeg?size=*:900",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRdw3tdBAyk4uTAXguUCdrpcoxWgm1M8r0jYw&s"
                }

            },

              new()
            {
                Name = "Uranus",
                Subtitle = " The Herschel Planet",
                HeroImage = "uranus.png",
                Description = "Uranus is the seventh planet from the Sun. It is a gaseous cyan-coloured ice giant. " +
                "Most of the planet is made of water, ammonia, and methane in a supercritical phase of matter, which in " +
                "astronomy is called 'ice' or volatiles. The planet's atmosphere has a complex layered cloud structure and " +
                "has the lowest minimum temperature of 49 K (−224 °C; −371 °F) out of all the Solar System's planets. It " +
                "has a marked axial tilt of 97.8° with a retrograde rotation rate of 17 hours. This means that in an " +
                "84-Earth-year orbital period around the Sun, its poles get around 42 years of continuous sunlight, followed " +
                "by 42 years of continuous darkness. ",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#996237"),
                Images = new()
                {
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSc2Rm9gNbKitob9-o3zI754jMyVL6VqLOCww&s",
                    "https://images.ctfassets.net/cnu0m8re1exe/5kMBUaBzV7Iq03C7e1ZsTZ/215894a6a88e73580d2cfe5370a88af5/shutterstock_1666194169.jpg?fm=jpg&fl=progressive&w=660&h=433&fit=fill"
                }

            },

              new()
            {
                Name = "Neptune",
                Subtitle = " The god of the sea",
                HeroImage = "neptune.png",
                Description = "Neptune is the eighth and farthest planet from the Sun. It is the fourth-largest planet " +
                "in the Solar System by diameter, the third-most-massive planet, and the densest giant planet. It is 17" +
                " times the mass of Earth, and slightly more massive than its near-twin Uranus. Neptune is denser and " +
                "physically smaller than Uranus because its greater mass causes more gravitational compression of its " +
                "atmosphere. Being composed primarily of gases and liquids, it has no well-defined solid surface. The " +
                "planet orbits the Sun once every 164.8 years at an orbital distance of 30.1 astronomical units (4.5 " +
                "billion kilometres; 2.8 billion miles). It is named after the Roman god of the sea and has the astronomical " +
                "symbol ♆, representing Neptune's trident.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://images-assets.nasa.gov/image/PIA01492/PIA01492~large.jpg?w=1920&h=1917&fit=clip&crop=faces%2Cfocalpoint",
                    "https://scx2.b-cdn.net/gfx/news/2016/1-whatisthesur.jpg"
                }

            },
               new()
            {
                Name = "Pluto",
                Subtitle = "The Star of Dwarf Planets",
                HeroImage = "pluto.png",
                Description = "Pluto (minor-planet designation: 134340 Pluto) is a dwarf planet in the Kuiper belt, a ring of bodies " +
                "beyond the orbit of Neptune. It is the ninth-largest and tenth-most-massive known object to directly orbit the Sun. It" +
                " is the largest known trans-Neptunian object by volume, by a small margin, but is slightly less massive than Eris. Like " +
                "other Kuiper belt objects, Pluto is made primarily of ice and rock and is much smaller than the inner planets. Pluto has" +
                " only one sixth the mass of Earth's moon, and one third its volume. Pluto was recognized as a planet until 2006. ",
                AccentColorStart = Color.FromArgb("#9b6547"),
                AccentColorEnd = Color.FromArgb("#efb493"),
                Images = new()
                {
                    "https://science.nasa.gov/wp-content/uploads/2023/06/color-image-of-pluto-pia20291-1.jpg?w=1536&format=webp",
                    "https://images-assets.nasa.gov/image/PIA20037/PIA20037~orig.jpg?w=1041&h=717&fit=clip&crop=faces%2Cfocalpoint",
                    "https://images-assets.nasa.gov/image/PIA20544/PIA20544~orig.jpg?w=855&h=582&fit=clip&crop=faces%2Cfocalpoint"
                }

            },

                new()
            {
                Name = "Eris",
                Subtitle = "Named for the ancient Greek goddess of discord and strife",
                HeroImage = "eris.png",
                Description = "Eris (minor-planet designation 136199 Eris) is the most massive and second-largest known " +
                "dwarf planet in the Solar System. It is a trans-Neptunian object (TNO) in the scattered disk and " +
                "has a high-eccentricity orbit. Eris was discovered in January 2005 by a Palomar Observatory–based team " +
                "led by Mike Brown and verified later that year. In September 2006, it was named after the Greco–Roman " +
                "goddess of strife and discord. Eris is the ninth-most massive known object orbiting the Sun and the " +
                "sixteenth-most massive overall in the Solar System (counting moons). It is also the largest known object " +
                "in the solar system that has not been visited by a spacecraft. Eris has been measured at 2,326 ± 12 kilometers (1,445 ± 7 mi)" +
                " in diameter;[12] its mass is 0.28% that of the Earth and 27% greater than that of Pluto, although Pluto is slightly larger by " +
                "volume. Both Eris and Pluto have a surface area that is comparable to the area of Russia or South America. ",
                AccentColorStart = Color.FromArgb("#C0C0C0"),
                AccentColorEnd = Color.FromArgb("#808080"),
                Images = new()
                {
                    "https://science.nasa.gov/wp-content/uploads/2023/06/Artists_c_oncept_of_Eris_and_Dysnomia_far_from_the_Sun-jpeg.webp?w=1536&format=webp",
                    "https://images-assets.nasa.gov/image/PIA03034/PIA03034~orig.jpg?w=603&h=200&fit=clip&crop=faces%2Cfocalpoint"
                }

            },
                new()
            {
                Name = "Haumea",
                Subtitle = " The Fastest Dwarf Planet",
                HeroImage = "haumea.png",
                Description = "Haumea (minor-planet designation 136108 Haumea) is a dwarf planet located beyond Neptune's orbit." +
                " It was discovered in 2004 by a team headed by Mike Brown of Caltech at the Palomar Observatory in the United " +
                "States and disputably also in 2005 by a team headed by José Luis Ortiz Moreno at the Sierra Nevada Observatory in " +
                "Spain. On September 17, 2008, it was named after Haumea, the Hawaiian goddess of childbirth, under the expectation " +
                "by the International Astronomical Union (IAU) that it would prove to be a dwarf planet. Nominal estimates make it " +
                "the third-largest known trans-Neptunian object, after Eris and Pluto, and approximately the size of Uranus's moon Titania. ",
                AccentColorStart = Color.FromArgb("#D2B48C\t"),
                AccentColorEnd = Color.FromArgb("#F5DEB3"),
                Images = new()
                {
                    "https://www.bobthealien.co.uk/bobpics/haumeaaigenerated.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/2/2b/Haumea_Hubble.png"
                }

            },

                 new()
            {
                Name = "Makemake",
                Subtitle = "codename \"Easterbunny\"",
                HeroImage = "makemake.png",
                Description = "Makemake[e] (minor-planet designation 136472 Makemake) is a dwarf planet and the second-largest " +
                "of what are known as the classical population of Kuiper belt objects, with a diameter approximately that of " +
                "Saturn's moon Iapetus, or 60% that of Pluto.[24][25] It has one known satellite.[26] Its extremely low average " +
                "temperature, about 40 K (−230 °C), means its surface is covered with methane, ethane, and possibly nitrogen ices.",
                AccentColorStart = Color.FromArgb("#8B4513"),
                AccentColorEnd = Color.FromArgb("#FFDEAD"),
                Images = new()
                {
                    "https://www.solarsystemscope.com/spacepedia/images/handbook/renders/makemake.png",
                    "https://cdn.mos.cms.futurecdn.net/8QBGiy9BhmttKdGeAAZpn8.jpg.webp"
                }

            },
                 new()
            {
                Name = "Ceres",
                Subtitle = "Ceres is named for the Roman goddess of corn and harvests.",
                HeroImage = "ceres.png",
                Description = "Ceres (pronounced /ˈsɪəriːz/ SEER-eez), minor-planet designation 1 Ceres, is a dwarf " +
                "planet in the middle main asteroid belt between the orbits of Mars and Jupiter. It was the first asteroid" +
                " discovered on 1 January 1801, by Giuseppe Piazzi at Palermo Astronomical Observatory in Sicily and announced" +
                " as a new planet. Ceres was later classified as an asteroid and then a dwarf planet, the only one always " +
                "inside Neptune's orbit. ",
                AccentColorStart = Color.FromArgb("#FAEBD7"),
                AccentColorEnd = Color.FromArgb("#FAF0E6"),
                Images = new()
                {
                    "https://cdn.mos.cms.futurecdn.net/qnft8kRfeGWWLgaygo4fb9.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/7/76/Ceres_-_RC3_-_Haulani_Crater_%2822381131691%29_%28cropped%29.jpg/435px-Ceres_-_RC3_-_Haulani_Crater_%2822381131691%29_%28cropped%29.jpg"

                }

            },


        };

        public static List<Planet> GetFeaturedPlanets()
        {
            var random = new Random();
            var randomizedPlanets = planets
                .OrderBy(item => random.Next());

            return randomizedPlanets
                .Take(2)
                .ToList();
        }

        public static List<Planet> GetAllPlanets()
            => planets;
    }
}