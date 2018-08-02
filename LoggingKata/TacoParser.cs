using System;


namespace LoggingKata
{
    /// <summary>
    /// Parses a POI file to locate all the Taco Bells
    /// </summary>
    public class TacoParser
    {
        readonly ILog logger = new TacoLogger();
        
        public ITrackable Parse(string line)
        {
            logger.LogInfo("Begin parsing");
            //_____________________________________________________________-
            
            
                // Take your line and use line.Split(',') to split it up into an array of strings, separated by the char ','
                string [] cells = line.Split(',');

            // If your array.Length is less than 3, something went wrong
            if (cells.Length < 3)
            {
                logger.LogWarning("Not enough values");
                return null;
                // Log that and return null
            }

            for (int i = 0; i < cells.Length; i++)
            {

                if (String.IsNullOrWhiteSpace(cells[i]))
                {
                    if (cells[i].Length > 0)
                    {
                        logger.LogInfo("Incomplete Data");
                        return null;
                    }
                    else
                    {
                        logger.LogFatal(null);
                        return null;
                    }
                }

            }

                    // grab the latitude from your array at index 0

                    string lat = cells[0];
            // grab the longitude from your array at index 1

            string longt = cells[1];

            // grab the name from your array at index 2

            string name = cells[2];


            // Your going to need to parse your string as a `double`

            double latD = Convert.ToDouble(lat);
            double lonD = Convert.ToDouble(longt);


            // You'll need to create a TacoBell class--DONE**********
            // that conforms to ITrackable --DONE*************

            // Then, you'll need an instance of the TacoBell class
            // With the name and point set correctly
            Point point1= new Point();
            point1.Latitude = latD;
            point1.Longitude = lonD;


            TacoBell tacobell = new TacoBell();
            tacobell.Name = name ;
            tacobell.Location = point1;





            // Then, return the instance of your TacoBell class
            // Since it conforms to ITrackable

            return tacobell; 


            //_______________________________________________________________

            // Do not fail if one record parsing fails, return null
            return null; // TODO Implement
        }
    }
}

//branch coomit