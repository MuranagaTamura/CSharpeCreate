using System;

namespace Utilities
{
    public class Keybord
    {
        private static Keybord myself_ = new Keybord();
        private string keyString_ = "";

        public static Keybord Instance
        {
            get
            {
                return myself_;
            }
        }

        public string Key
        {
            get
            {
                return keyString_;
            }
            set
            {
                keyString_ = value;
            }
        }

        public override string ToString()
        {
            return System.String.Format("KeyBord:[{0,7}]",keyString_);
        }

        private Keybord()
        {
        }
    }
}