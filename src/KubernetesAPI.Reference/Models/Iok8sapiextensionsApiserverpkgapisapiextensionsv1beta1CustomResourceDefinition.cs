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
    /// CustomResourceDefinition represents a resource that should be exposed
    /// on the API server.  Its name MUST be in the format
    /// &lt;.spec.name&gt;.&lt;.spec.group&gt;.
    /// </summary>
    public partial class Iok8sapiextensionsApiserverpkgapisapiextensionsv1beta1CustomResourceDefinition
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapiextensionsApiserverpkgapisapiextensionsv1beta1CustomResourceDefinition
        /// class.
        /// </summary>
        public Iok8sapiextensionsApiserverpkgapisapiextensionsv1beta1CustomResourceDefinition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapiextensionsApiserverpkgapisapiextensionsv1beta1CustomResourceDefinition
        /// class.
        /// </summary>
        /// <param name="apiVersion">APIVersion defines the versioned schema of
        /// this representation of an object. Servers should convert recognized
        /// schemas to the latest internal value, and may reject unrecognized
        /// values. More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</param>
        /// <param name="kind">Kind is a string value representing the REST
        /// resource this object represents. Servers may infer this from the
        /// endpoint the client submits requests to. Cannot be updated. In
        /// CamelCase. More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</param>
        /// <param name="spec">Spec describes how the user wants the resources
        /// to appear</param>
        /// <param name="status">Status indicates the actual state of the
        /// CustomResourceDefinition</param>
        public Iok8sapiextensionsApiserverpkgapisapiextensionsv1beta1CustomResourceDefinition(string apiVersion = default(string), string kind = default(string), Iok8sapimachinerypkgapismetav1ObjectMeta metadata = default(Iok8sapimachinerypkgapismetav1ObjectMeta), Iok8sapiextensionsApiserverpkgapisapiextensionsv1beta1CustomResourceDefinitionSpec spec = default(Iok8sapiextensionsApiserverpkgapisapiextensionsv1beta1CustomResourceDefinitionSpec), Iok8sapiextensionsApiserverpkgapisapiextensionsv1beta1CustomResourceDefinitionStatus status = default(Iok8sapiextensionsApiserverpkgapisapiextensionsv1beta1CustomResourceDefinitionStatus))
        {
            ApiVersion = apiVersion;
            Kind = kind;
            Metadata = metadata;
            Spec = spec;
            Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets aPIVersion defines the versioned schema of this
        /// representation of an object. Servers should convert recognized
        /// schemas to the latest internal value, and may reject unrecognized
        /// values. More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#resources
        /// </summary>
        [JsonProperty(PropertyName = "apiVersion")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Gets or sets kind is a string value representing the REST resource
        /// this object represents. Servers may infer this from the endpoint
        /// the client submits requests to. Cannot be updated. In CamelCase.
        /// More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public Iok8sapimachinerypkgapismetav1ObjectMeta Metadata { get; set; }

        /// <summary>
        /// Gets or sets spec describes how the user wants the resources to
        /// appear
        /// </summary>
        [JsonProperty(PropertyName = "spec")]
        public Iok8sapiextensionsApiserverpkgapisapiextensionsv1beta1CustomResourceDefinitionSpec Spec { get; set; }

        /// <summary>
        /// Gets or sets status indicates the actual state of the
        /// CustomResourceDefinition
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public Iok8sapiextensionsApiserverpkgapisapiextensionsv1beta1CustomResourceDefinitionStatus Status { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Metadata != null)
            {
                Metadata.Validate();
            }
            if (Spec != null)
            {
                Spec.Validate();
            }
            if (Status != null)
            {
                Status.Validate();
            }
        }
    }
}
