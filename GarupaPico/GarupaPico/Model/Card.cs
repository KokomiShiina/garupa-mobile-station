﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GarupaPico.Model
{
    class Card
    {
        private string _imgPath;

        /// <summary>
        /// Gets card id from the game.
        /// </summary>
        public int Id { get; private set; } = -1;

        /// <summary>
        /// Gets card title.
        /// </summary>
        public string CardName { get; private set; } = "<なし>";

        /// <summary>
        /// Gets card character band.
        /// </summary>
        public string Band { get; private set; }

        /// <summary>
        /// Gets card character name.
        /// </summary>
        public MemberName CharacterName { get; private set; }

        /// <summary>
        /// Gets 1-4 star. 
        /// 0 for dummy card, which is set when you create dummy object.
        /// </summary>
        public int Rarity { get; private set; }

        /// <summary>
        /// Gets card type as powerful / pure / cool / happy.
        /// "N/A" for dummy card, which is set when you create dummy object.
        /// </summary>
        public string Type { get; private set; }

        /// <summary>
        /// Gets power value of the card.
        /// 0 for dummy card, which is set when you create dummy object.
        /// </summary>
        public int Pow { get; private set; }

        /// <summary>
        /// Gets technique value of the card.
        /// 0 for dummy card, which is set when you create dummy object.
        /// </summary>
        public int Tech { get; private set; }

        /// <summary>
        /// Gets visual value of the card.
        /// 0 for dummy card, which is set when you create dummy object. 
        /// </summary>
        public int Vis { get; private set; }

        /// <summary>
        /// Gets the sum up value of power + technique + visual, calculated automatically. 
        /// </summary>
        public int Total => Pow + Tech + Vis;

        /// <summary>
        /// Gets card skill description.
        /// </summary>
        public string SkillType { get; private set; }

        /// <summary>
        /// Gets percentage of score up by card skill.
        /// </summary>
        public int ScorePercent { get; private set; }

        /// <summary>
        /// Gets skill last at minimum skill level.
        /// </summary>
        public float SkillLastMin { get; private set; }

        /// <summary>
        /// Gets skill last at maximum skill level.
        /// </summary>
        public float SkillLastMax { get; private set; }

        /// <summary>
        /// Gets online image path.
        /// </summary>
        public string ImgPath
        {
            get => _imgPath;
            private set => _imgPath = "https://i.imgur.com/" + value;
        }
        
        public Card() {
            SkillLastMin = 5.0f;
        }

        public string GetBand() {
            if (Band.Equals("Poppin'Party", StringComparison.OrdinalIgnoreCase))
                return "Poppin' Party";
            return Band;
        }
    }
}
