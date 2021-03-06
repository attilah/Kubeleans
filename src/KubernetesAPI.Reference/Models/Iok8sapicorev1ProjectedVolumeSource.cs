// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kubeleans.KubernetesApi.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents a projected volume source
    /// </summary>
    public partial class Iok8sapicorev1ProjectedVolumeSource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapicorev1ProjectedVolumeSource class.
        /// </summary>
        public Iok8sapicorev1ProjectedVolumeSource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapicorev1ProjectedVolumeSource class.
        /// </summary>
        /// <param name="sources">list of volume projections</param>
        /// <param name="defaultMode">Mode bits to use on created files by
        /// default. Must be a value between 0 and 0777. Directories within the
        /// path are not affected by this setting. This might be in conflict
        /// with other options that affect the file mode, like fsGroup, and the
        /// result can be other mode bits set.</param>
        public Iok8sapicorev1ProjectedVolumeSource(IList<Iok8sapicorev1VolumeProjection> sources, int? defaultMode = default(int?))
        {
            DefaultMode = defaultMode;
            Sources = sources;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets mode bits to use on created files by default. Must be
        /// a value between 0 and 0777. Directories within the path are not
        /// affected by this setting. This might be in conflict with other
        /// options that affect the file mode, like fsGroup, and the result can
        /// be other mode bits set.
        /// </summary>
        [JsonProperty(PropertyName = "defaultMode")]
        public int? DefaultMode { get; set; }

        /// <summary>
        /// Gets or sets list of volume projections
        /// </summary>
        [JsonProperty(PropertyName = "sources")]
        public IList<Iok8sapicorev1VolumeProjection> Sources { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Sources == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Sources");
            }
        }
    }
}
