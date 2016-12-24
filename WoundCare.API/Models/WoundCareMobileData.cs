using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WoundCare.API.Models
{
    public class WoundCareMobileData
    {
        public FeelToday FeelToday
        {
            get;
            set;
        }

        public WoundDrainage WoundDrainage
        {
            get; set;
        }

        public DrainageColor DrainageColor
        {
            get; set;
        }

        public Fever Fever
        {
            get; set;
        }

        public Temperature Temperature
        {
            get; set;
        }

        public PainFromWound PainFromWound
        {
            get; set;
        }

        public SmellOdor SmellOdor
        {
            get; set;
        }

        public SmellOdorDetail SmellOdorDetail
        {
            get; set;
        }

        public Inflamed Inflamed
        {
            get; set;
        }

        public Inflammation Inflammation
        {
            get; set;
        }

        public WoundSwelling WoundSwelling
        {
            get; set;
        }

        public WoundSize WoundSize
        {
            get; set;
        }
    }

    /// <summary>
    /// mobile class feel today
    /// </summary>
    public class FeelToday
    {
        public bool Happy
        {
            get; set;
        }

        public bool Sad
        {
            get; set;
        }

        public bool Verysad
        {
            get;
            set;
        }
    }

    /// <summary>
    /// class describes wound drainage 
    /// </summary>
    public class WoundDrainage
    {
        public bool None
        {
            get; set;
        }
        public bool Same
        {
            get; set;
        }
        public bool Less
        {
            get; set;
        }
        public bool More
        {
            get; set;
        }
    }

    /// <summary>
    /// class describes drainage color
    /// </summary>
    public class DrainageColor
    {
        public bool ClearOryellow { get; set; }

        public bool BrownOrBody { get; set; }
    }

    /// <summary>
    /// class describes fever 
    /// </summary>
    public class Fever
    {
        public bool Yes { get; set; }

        public bool No { get; set; }
    }

    /// <summary>
    /// class describes fever temperature
    /// </summary>
    public class Temperature
    {
        public string Value { get; set; }
    }

    /// <summary>
    /// class describes pain from wound
    /// </summary>
    public class PainFromWound
    {
        public bool None
        {
            get; set;
        }

        public bool Same
        {
            get; set;
        }
        public bool Less
        {
            get; set;
        }

        public bool More
        {
            get; set;
        }
    }

    /// <summary>
    /// class describes smell odor details
    /// </summary>
    public class SmellOdor
    {
        public bool Yes
        {
            get; set;
        }

        public bool None
        {
            get; set;
        }
    }

    /// <summary>
    /// class describes smell odor details
    /// </summary>
    public class SmellOdorDetail
    {
        public bool IsNew
        {
            get; set;
        }

        public bool Same
        {
            get; set;
        }

        public bool Worse
        {
            get; set;
        }
    }

    /// <summary>
    /// class describes inflamed details
    /// </summary>
    public class Inflamed
    {
        public bool Yes
        {
            get;
            set;
        }

        public bool No
        {
            get; set;
        }
    }

    /// <summary>
    /// class for inflammation details
    /// </summary>
    public class Inflammation
    {
        public bool Less
        {
            get; set;
        }

        public bool Same
        {
            get; set;
        }

        public bool Worse
        {
            get; set;
        }
    }

    /// <summary>
    /// class for wound swelling
    /// </summary>
    public class WoundSwelling
    {
        public bool No
        {
            get; set;
        }

        public bool Less
        {
            get; set;
        }

        public bool Same
        {
            get; set;
        }

        public bool More
        {
            get; set;
        }
    }

    /// <summary>
    /// class describes wound size 
    /// </summary>
    public class WoundSize
    {
        public string Length { get; set; }

        public string Width { get; set; }
    }
}