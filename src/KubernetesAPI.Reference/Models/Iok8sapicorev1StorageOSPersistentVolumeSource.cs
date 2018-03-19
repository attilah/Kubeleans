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
    /// Represents a StorageOS persistent volume resource.
    /// </summary>
    public partial class Iok8sapicorev1StorageOSPersistentVolumeSource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapicorev1StorageOSPersistentVolumeSource class.
        /// </summary>
        public Iok8sapicorev1StorageOSPersistentVolumeSource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapicorev1StorageOSPersistentVolumeSource class.
        /// </summary>
        /// <param name="fsType">Filesystem type to mount. Must be a filesystem
        /// type supported by the host operating system. Ex. "ext4", "xfs",
        /// "ntfs". Implicitly inferred to be "ext4" if unspecified.</param>
        /// <param name="readOnlyProperty">Defaults to false (read/write).
        /// ReadOnly here will force the ReadOnly setting in
        /// VolumeMounts.</param>
        /// <param name="secretRef">SecretRef specifies the secret to use for
        /// obtaining the StorageOS API credentials.  If not specified, default
        /// values will be attempted.</param>
        /// <param name="volumeName">VolumeName is the human-readable name of
        /// the StorageOS volume.  Volume names are only unique within a
        /// namespace.</param>
        /// <param name="volumeNamespace">VolumeNamespace specifies the scope
        /// of the volume within StorageOS.  If no namespace is specified then
        /// the Pod's namespace will be used.  This allows the Kubernetes name
        /// scoping to be mirrored within StorageOS for tighter integration.
        /// Set VolumeName to any name to override the default behaviour. Set
        /// to "default" if you are not using namespaces within StorageOS.
        /// Namespaces that do not pre-exist within StorageOS will be
        /// created.</param>
        public Iok8sapicorev1StorageOSPersistentVolumeSource(string fsType = default(string), bool? readOnlyProperty = default(bool?), Iok8sapicorev1ObjectReference secretRef = default(Iok8sapicorev1ObjectReference), string volumeName = default(string), string volumeNamespace = default(string))
        {
            FsType = fsType;
            ReadOnlyProperty = readOnlyProperty;
            SecretRef = secretRef;
            VolumeName = volumeName;
            VolumeNamespace = volumeNamespace;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets filesystem type to mount. Must be a filesystem type
        /// supported by the host operating system. Ex. "ext4", "xfs", "ntfs".
        /// Implicitly inferred to be "ext4" if unspecified.
        /// </summary>
        [JsonProperty(PropertyName = "fsType")]
        public string FsType { get; set; }

        /// <summary>
        /// Gets or sets defaults to false (read/write). ReadOnly here will
        /// force the ReadOnly setting in VolumeMounts.
        /// </summary>
        [JsonProperty(PropertyName = "readOnly")]
        public bool? ReadOnlyProperty { get; set; }

        /// <summary>
        /// Gets or sets secretRef specifies the secret to use for obtaining
        /// the StorageOS API credentials.  If not specified, default values
        /// will be attempted.
        /// </summary>
        [JsonProperty(PropertyName = "secretRef")]
        public Iok8sapicorev1ObjectReference SecretRef { get; set; }

        /// <summary>
        /// Gets or sets volumeName is the human-readable name of the StorageOS
        /// volume.  Volume names are only unique within a namespace.
        /// </summary>
        [JsonProperty(PropertyName = "volumeName")]
        public string VolumeName { get; set; }

        /// <summary>
        /// Gets or sets volumeNamespace specifies the scope of the volume
        /// within StorageOS.  If no namespace is specified then the Pod's
        /// namespace will be used.  This allows the Kubernetes name scoping to
        /// be mirrored within StorageOS for tighter integration. Set
        /// VolumeName to any name to override the default behaviour. Set to
        /// "default" if you are not using namespaces within StorageOS.
        /// Namespaces that do not pre-exist within StorageOS will be created.
        /// </summary>
        [JsonProperty(PropertyName = "volumeNamespace")]
        public string VolumeNamespace { get; set; }

    }
}