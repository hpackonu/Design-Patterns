using System;

    class Singleton
    {
        private static Singleton instance;
        private string Color;
        private Singleton()
        {}

        public static Singleton getInstance(string FavColor)
        {
            if (instance == null)
            {
                instance = new Singleton();
                instance.setColor(FavColor);
            }

            return instance;
        }
	    public void clear()
        {
            instance = null;
        }
        public void setColor(string FavoriteColor)
        {
                Color = FavoriteColor;
        }
    public string getColor()
    {
        return Color;
    }
    }
