using System;
using System.Collections.Generic;
using System.Text;

namespace SkyNetOS
{
    class Player
    {


        public string PlayerName { get; private set; }
        public int PlayerAge { get; private set; }
        public int PlayerHealth { get; private set; }
        public int PlayerLevel { get; set; }


        /// <summary>
        /// Allow game to add and remove things to players inv.
        /// </summary>
        public Dictionary<string, string> PlayerInvintory { get; set; }


        public string PlayerCatchPhrase { get; set; }




        public Player(string playerName, int playerAge, string phrase)
        {

            this.PlayerName = playerName;
            this.PlayerAge = playerAge;
            this.PlayerCatchPhrase = phrase;

            this.PlayerHealth = playerAge + 55;  //sets play healthe relative to age

        }


        public void PlayerCatchphrase()
        {



        }









    }
}
