using BakaXL.Core.Launchers;
using BakaXL.Core.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakaXL.Core.Identities.Standards
{
    public class OnlineIdentity : IIdentity
    {
        //This is Class on workspace cannot use

        protected virtual string PlayerType => "microsoft"; 

        public Guid PlayerId { get; }

        public string PlayerName { get; }

        public OnlineIdentity(Guid id, string name)
        {
            //TO-DO
            PlayerId = id;
            PlayerName = name;
        }

        public OnlineIdentity(string name) : this(UUIDConverter.GetOnlineUUIDFromPlayerAccount(name), name)
        { //TO-DO
        
        }

        public void SetLaunchProperties(LaunchProperties properties)
        {
            //TO-DO
            properties.PlayerType = PlayerType;
            properties.PlayerId = PlayerId;
            properties.PlayerName = PlayerName;
            properties.PlayerProperties = "{}";
            properties.AccessToken = PlayerId.ToString("N");
        }

        public ValueTask<IIdentity> Auth()
        {
            //TO-DO
            throw new NotImplementedException();
        }
    }
}
