// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kubeleans.KubernetesApi.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// ContainerStateRunning is a running state of a container.
    /// </summary>
    public partial class Iok8sapicorev1ContainerStateRunning
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapicorev1ContainerStateRunning class.
        /// </summary>
        public Iok8sapicorev1ContainerStateRunning()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapicorev1ContainerStateRunning class.
        /// </summary>
        /// <param name="startedAt">Time at which the container was last
        /// (re-)started</param>
        public Iok8sapicorev1ContainerStateRunning(System.DateTimeOffset? startedAt = default(System.DateTimeOffset?))
        {
            StartedAt = startedAt;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets time at which the container was last (re-)started
        /// </summary>
        [JsonProperty(PropertyName = "startedAt")]
        public System.DateTimeOffset? StartedAt { get; set; }

    }
}
