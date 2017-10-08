using Imd.Data.Interfaces;
using Imd.Domain.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static Imd.Domain.Enums;

namespace Imd.Data.Repositories
{
    public class StubVideoClipsRepository : IVideoClipsRepository<VideoClip>
    {
        private IList<VideoClip> inMemoryClips;

        public StubVideoClipsRepository()
        {
            inMemoryClips = Seed();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public VideoClip Get(Guid id)
        {
            return inMemoryClips.Where(c => c.Id == id).FirstOrDefault();
        }

        public IList<VideoClip> GetAll()
        {
            return inMemoryClips.ToList();
        }

        public IList<VideoClip> GetAll(Guid userId)
        {
            //todo: filtering using user id to be added
            return inMemoryClips.ToList();
        }

        public VideoClip Update(VideoClip obj)
        {
            throw new NotImplementedException();
        }

        #region Seeding

        private static IList<VideoClip> Seed()
        {
            return new List<VideoClip>
            {
                new VideoClip
                {
                    Id = Guid.NewGuid(),
                    Name = "Bud Light",
                    Description = "A factory is working on the new Bud Light Platinum.",
                    VStandard = VideoStandard.PAL,
                    VDefinition = VideoDefinition.SD,
                    Start = new TimeCode(0,0,0,0, VideoStandard.PAL),
                    End = new TimeCode(0,0,30,12, VideoStandard.PAL)
                },
                new VideoClip
                {
                    Id = Guid.NewGuid(),
                    Name = "M&M's",
                    Description = "At a party, a brown-shelled M&M is mistaken for being naked. As a result, the red M&M tears off its skin and dances to \"Sexy and I Know It\" by LMFAO.",
                    VStandard = VideoStandard.NTSC,
                    VDefinition = VideoDefinition.SD,
                    Start = new TimeCode(0,0,0,0, VideoStandard.NTSC),
                    End = new TimeCode(0,0,15,27, VideoStandard.NTSC)
                },
                new VideoClip
                {
                    Id = Guid.NewGuid(),
                    Name = "Audi",
                    Description = "A group of vampires are having a party in the woods. The vampire in charge of drinks (blood types) arrives in his Audi. The bright lights of the car kills all of the vampires, with him wondering where everyone went afterwards.",
                    VStandard = VideoStandard.PAL,
                    VDefinition = VideoDefinition.SD,
                    Start = new TimeCode(00,00,00,00, VideoStandard.PAL),
                    End = new TimeCode(00,01,30,00, VideoStandard.PAL)
                },
                new VideoClip
                {
                    Id = Guid.NewGuid(),
                    Name = "Chrysler",
                    Description = " Clint Eastwood recounts how the automotive industry survived the Great Recession.",
                    VStandard = VideoStandard.PAL,
                    VDefinition = VideoDefinition.SD,
                    Start = new TimeCode(00,00,00,00, VideoStandard.PAL),
                    End = new TimeCode(00,00,10,14, VideoStandard.PAL)
                },
                new VideoClip
                {
                    Id = Guid.NewGuid(),
                    Name = "Fiat",
                    Description = "A man walks through a street to discover a beautiful woman (Catrinel Menghia) standing on a parking space, who proceeds to approach and seduce him, when successfully doing so he then discovered he was about to kiss a Fiat 500 Abarth.",
                    VStandard = VideoStandard.NTSC,
                    VDefinition = VideoDefinition.SD,
                    Start = new TimeCode(0,0,0,0,VideoStandard.NTSC),
                    End = new TimeCode(0,0,18,11,VideoStandard.NTSC)
                },
                new VideoClip
                {
                    Id = Guid.NewGuid(),
                    Name = "Pepsi",
                    Description = " People in the Middles Ages try to entertain their king (Elton John) for a Pepsi. While the first person fails, a mysterious person(Season 1 X Factor winner Melanie Amaro) wins the Pepsi by singing Aretha Franklin's \"Respect\". After she wins, she overthrows the king and gives Pepsi to all the town.",
                    VStandard = VideoStandard.NTSC,
                    VDefinition = VideoDefinition.SD,
                    Start = new TimeCode(0,0,0,0,VideoStandard.NTSC),
                    End = new TimeCode(0,0,20,0,VideoStandard.NTSC)
                },
                new VideoClip
                {
                    Id = Guid.NewGuid(),
                    Name = "Best Buy",
                    Description = " An ad featuring the creators of the cameraphone, Siri, and the first text message. The creators of Words with Friends also appear parodying the incident involving Alec Baldwin playing the game on an airplane.",
                    VStandard = VideoStandard.PAL,
                    VDefinition = VideoDefinition.HD,
                    Start = new TimeCode(0,0,0,0,VideoStandard.PAL),
                    End = new TimeCode(0,0,10,05,VideoStandard.PAL)
                },
                new VideoClip
                {
                    Id = Guid.NewGuid(),
                    Name = "Captain America: The First Avenger",
                    Description = "Video Promo.",
                    VStandard = VideoStandard.PAL,
                    VDefinition = VideoDefinition.HD,
                    Start = new TimeCode(0,0,0,0,VideoStandard.PAL),
                    End = new TimeCode(0,0,20,10,VideoStandard.PAL)
                },
                new VideoClip
                {
                    Id = Guid.NewGuid(),
                    Name = "Volkswagen \"Black Beetle\"",
                    Description = "A factory is working on the new Bud Light Platinum.",
                    VStandard = VideoStandard.NTSC,
                    VDefinition = VideoDefinition.HD,
                    Start = new TimeCode(0,0,0,0,VideoStandard.PAL),
                    End = new TimeCode(0,0,30,0,VideoStandard.PAL)
                }
            };
        }

        #endregion
    }
}
