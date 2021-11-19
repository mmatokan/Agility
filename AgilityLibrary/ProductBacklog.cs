﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Agility.DomainModel
{
    public class ProductBacklog
    {
        private Project _project;
        private long _backlogID;

        /// <summary>
        /// Represents unique, autogenerated id.
        /// </summary>
        public virtual long BacklogId
        {
            get { return _backlogID; }
            set { _backlogID = value; }
        }

        /// <summary>
        /// Represents the project this product backlog is part of.
        /// </summary>
        public virtual Project Project
        {
            get { return _project; }
            set { _project = value; }
        }

        /// <summary>
        /// Represents list of requirements for the whole project.
        /// </summary>
        public virtual IList<Requirement> BacklogRequirements { get; set; } 

        public ProductBacklog()
        {
        }

    }
}