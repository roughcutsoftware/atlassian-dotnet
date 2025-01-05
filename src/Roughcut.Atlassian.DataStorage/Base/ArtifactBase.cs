using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Roughcut.Atlassian.Interfaces;
using Roughcut.Atlassian.Interfaces.Extensions;

namespace Roughcut.Atlassian.DataStorage.Base
{
    public abstract class ArtifactBase : IArtifact
    {
        private Guid _artifactKeyId = Guid.Empty;

        [Key]
        [Required]
        public Guid ArtifactKeyId
        {
            get
            {
                if (_artifactKeyId == Guid.Empty)
                {
                    _artifactKeyId = Guid.NewGuid();
                }

                return _artifactKeyId;
            }

            set
            {

                if (value == Guid.Empty)
                {
                    this._artifactKeyId = Guid.NewGuid();
                }
                else
                {
                    this._artifactKeyId = value;
                }
            }
        }

        public string? ShortKeyId { get; set; }

        public ArtifactBase()
        {
            //this.ModelType = this.GetType().Name.ToLower().Replace("model", "");

            //if (this.ArtifactKeyId == null)
            //{
            //    this.ArtifactKeyId = Guid.NewGuid();
            //}

            this.ArtifactKeyId = Guid.NewGuid();
            
            //this.ArtifactType = "youtube-keyword".ToLower();
            this.ArtifactType = this.GetType().Name.ToLower(); //.Replace("model", "");

            //
            this.ShortKeyId = this.GetShortStringId();

        }


        //[Required]
        //[Unicode(false)]
        //public string Name { get; set; }

        public string ArtifactType { get; set; }

        //public string ArtifactType
        //{
        //    get
        //    {
        //        return ModelType;
        //    }

        //    set => ModelType = value;
        //}

        //public string? Description { get; set; }

        //public string? ModelTypeCode { get; set; }
        //public string? ModelCategory { get; set; }


    }
}
