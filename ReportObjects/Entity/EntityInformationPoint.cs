﻿using System;

namespace AppDynamics.Dexter.DataObjects
{
    public class EntityInformationPoint: EntityBase
    {
        public const string ENTITY_TYPE = "Information Point";
        public const string ENTITY_FOLDER = "IP";

        public long IPID { get; set; }
        public string IPLink { get; set; }
        public string IPName { get; set; }

        public string IPType { get; set; }

        public override long EntityID
        {
            get
            {
                return this.IPID;
            }
        }
        public override string EntityName
        {
            get
            {
                return this.IPName;
            }
        }
        public override string EntityType
        {
            get
            {
                return ENTITY_TYPE;
            }
        }
        public override string FolderName
        {
            get
            {
                return ENTITY_FOLDER;
            }
        }

        public EntityInformationPoint Clone()
        {
            return (EntityInformationPoint)this.MemberwiseClone();
        }

        public override String ToString()
        {
            return String.Format(
                "EntityInformationPoint: {0}/{1}({2})/{3}({4})",
                this.Controller,
                this.ApplicationName,
                this.ApplicationID,
                this.IPName,
                this.IPID);
        }
    }
}
