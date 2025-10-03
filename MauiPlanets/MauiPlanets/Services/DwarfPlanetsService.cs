using MauiPlanets.Models;


namespace MauiPlanets.Services
{
    internal class DwarfPlanetsService
    {
        private static List<DwarfPlanet> dwarf_planets = new()
        {
            new()
            {
                Name = "Pluto",
                Subtitle = "The Star of Dwarf Planets",
                HeroImage = "pluto.png",
                Description = "Pluto is by far the most famous dwarf planet. " +
                "Discovered by Clyde Tombaugh in 1930, Pluto was long considered " +
                "our solar system's ninth planet. But after other astronomers found " +
                "similar intriguing worlds deeper in the distant Kuiper Belt – the IAU " +
                "reclassified Pluto as a dwarf planet in 2006.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse4.mm.bing.net%2Fth%2Fid%2FOIP.G9ZXwxf83CrCgHRYdKw84gHaHa%3Fcb%3D12%26pid%3DApi&f=1&ipt=b31e368bc86a213eace29d3e036d36ec997b81c960388a1ca6048dc0fea7b817&ipo=images"
                }
            },
            new()
            {
                Name = "Haumea",
                Subtitle = "The spinning football",
                HeroImage = "haumea.png",
                Description = "Dwarf planet Haumea was originally designated 2003 EL61 " +
                "(and nicknamed Santa by one discovery team). Haumea is located in the Kuiper Belts, " +
                "a doughnut-shaped region of icy bodies beyond the orbit of Neptune. Haumea " +
                "is an oval-shaped dwarf planet that is one of the fastest rotating large " +
                "objects in our solar system. The fast spin distorts Haumea's shape, making " +
                "this dwarf planet look like a football.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                  "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse2.mm.bing.net%2Fth%2Fid%2FOIP.MklH37daw3ful711WPwO7wHaEu%3Fcb%3D12%26pid%3DApi&f=1&ipt=794b6cd22072625d01bfdd9d31c10fc8753f9b4687099401ec2a67c8954a9cc1&ipo=images"
                }
            },
            new()
            {
                Name = "Makemake",
                Subtitle = "Kuiper's donut",
                HeroImage = "makemake.png",
                Description = "Dwarf planet Makemake – along with Pluto, " +
                "Haumea, and Eris – is located in the Kuiper Belt, a " +
                "donut-shaped region of icy bodies beyond the orbit of Neptune. " +
                "Makemake is slightly smaller than Pluto, and is the second-brightest " +
                "object in the Kuiper Belt as seen from Earth while Pluto is the brightest. " +
                "It takes about 305 Earth years for this dwarf planet to make one trip around the Sun." +
                "\r\n\r\nMakemake holds an important place in the history of solar system studies because" +
                " it was one of the objects – along with Eris – whose discovery prompted the " +
                "International Astronomical Union to reconsider the definition of a planet, " +
                "and to create the new group of dwarf planets.\r\n\r\nMakemake was first observed in " +
                "March 2005 by M.E. Brown, C.A. Trujillo, and D.L. Rabinowitz at the Palomar " +
                "Observatory, California. Its unofficial codename was Easterbunny, Brown said, " +
                "\"in honor of the fact that it was discovered just a few days past Easter.\" " +
                "Before this dwarf planet was confirmed, its provisional name was 2005 FY9. " +
                "In 2016, NASA’s Hubble Space Telescope spotted a small, dark moon orbiting Makemake.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse3.mm.bing.net%2Fth%2Fid%2FOIP.VJhpNRrxh1ONISb78Ix47AHaGN%3Fcb%3D12%26pid%3DApi&f=1&ipt=b5d827a68c56501812bfbf041df6a3af689bd137cdf4737b6ed035a3cdd2bc70&ipo=images"
                }
            },
            new()
            {
                Name = "Eris",
                Subtitle = "Goddess of discord",
                HeroImage = "eris.png",
                Description = "Eris is one of largest the dwarf planets in our solar system. " +
                "It's about the same size as Pluto, but it's three times farther from the Sun." +
                "The discovery of Eris help trigger a debate in the scientific community that " +
                "led to the International Astronomical Union's decision in 2006 to clarify the " +
                "definition of a planet. Pluto, Eris, and other similar objects are now classified " +
                "as dwarf planets.\r\n\r\nEris was discovered on Jan. 5, 2005, from data obtained on " +
                "Oct. 21, 2003, during a Palomar Observatory survey of the outer solar system by Mike " +
                "Brown, a professor of planetary astronomy at the California Institute of Technology; " +
                "Chad Trujillo of the Gemini Observatory; and David Rabinowitz of Yale University. " +
                "Here are some key dates in the discovery of Eris:\r\n\r\n    " +
                "Jan 8, 2005: Scientists announce they have discovered a Pluto-sized " +
                "world billions of miles beyond the orbit of Neptune. They nickname the " +
                "tiny world Xena after a fictional television character. The discovery reignites a " +
                "debate about the definition of a planet.\r\n    Sep 2005: Scientists announce Xena " +
                "has a tiny moon, which they nickname Gabriella after Xena's sidekick on a television " +
                "show about a warrior princess.\r\n    Aug 26, 2006: After months of debate about " +
                "how to classify Eris, the International Astronomical Union votes to " +
                "change the definition of a planet. The new ruling reclassifies Pluto as a " +
                "dwarf planet and reduces the number of planets in the solar system to eight. " +
                "Both Eris and the asteroid Ceres are also classified as dwarf planets.\r\n    " +
                "Sep 14, 2006: The International Astronomical Union (IAU) announces that the" +
                " dwarf planet known as Xena will be called Eris, after the Greek goddess of discord. " +
                "Eris's moon is named Dysnomia, the demon goddess of lawlessness and the daughter of Eris." +
                " This is fitting since the discovery of Eris led to the demotion of Pluto from planet " +
                "to dwarf planet amidst continuing debate in the science community and the public.\r\n",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse3.mm.bing.net%2Fth%2Fid%2FOIP.kT1dKy6GQ_huAkG5oTJn8gHaE8%3Fcb%3D12%26pid%3DApi&f=1&ipt=fb159793a0f31b988de9c75175e3beda21a2f2ce5ccca30e7d758574c6685d55&ipo=images"
                }
            },
            new()
            {
                Name = "Ceres",
                Subtitle = "The Star of Dwarf Planets",
                HeroImage = "ceres.png",
                Description = "Ceres is the only dwarf planet in the inner solar system." +
                "\r\n\r\nCeres was the first member of the asteroid belt to be discovered when " +
                "Giuseppe Piazzi spotted it in 1801. Called an asteroid for many years, " +
                "Ceres is so much bigger and so different from its rocky neighbors that " +
                "scientists classified it as a dwarf planet in 2006. " +
                "When NASA's Dawn arrived in 2015, Ceres became the first dwarf planet " +
                "to receive a visit from a spacecraft. ",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse1.mm.bing.net%2Fth%2Fid%2FOIP.4fwqGjL3ykoae5-hPC1dGAHaEc%3Fpid%3DApi&f=1&ipt=2dde556a06c31b3f9601b9d63c77caa5b1dc8d63f396b4a119569dc018340c3e&ipo=images"
                }
            },
        };
        public static List<DwarfPlanet> GetAllDwarfPlanets()
            => dwarf_planets;
    }
}
