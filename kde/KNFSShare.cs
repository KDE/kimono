//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
    using System;
    using Qyoto;
    using System.Collections.Generic;
    /// <remarks>
    ///  Similar functionality like KFileShare, 
    ///  but works only for NFS and do not need 
    ///  any suid script.
    ///  It parses the /etc/exports file to get its information.
    ///  Singleton class, call instance() to get an instance.
    ///  </remarks>        <short>    Similar functionality like KFileShare,   but works only for NFS and do not need   any suid script.</short>
    [SmokeClass("KNFSShare")]
    public class KNFSShare : QObject {
        protected KNFSShare(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(KNFSShare), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static KNFSShare() {
            staticInterceptor = new SmokeInvocation(typeof(KNFSShare), null);
        }
        /// <remarks>
        ///  Whether or not the given path is shared by NFS.
        /// <param> name="path" the path to check if it is shared by NFS.
        /// </param></remarks>        <return> whether the given path is shared by NFS.
        ///    </return>
        ///         <short>    Whether or not the given path is shared by NFS.</short>
        public bool IsDirectoryShared(string path) {
            return (bool) interceptor.Invoke("isDirectoryShared$", "isDirectoryShared(const QString&) const", typeof(bool), typeof(string), path);
        }
        /// <remarks>
        ///  Returns a list of all directories shared by NFS.
        ///  The resulting list is not sorted.
        /// </remarks>        <return> a list of all directories shared by NFS.
        ///    </return>
        ///         <short>    Returns a list of all directories shared by NFS.</short>
        public List<string> SharedDirectories() {
            return (List<string>) interceptor.Invoke("sharedDirectories", "sharedDirectories() const", typeof(List<string>));
        }
        /// <remarks>
        ///  Returns the path to the used exports file,
        ///  or null if no exports file was found
        ///    </remarks>        <short>    Returns the path to the used exports file,  or null if no exports file was found    </short>
        public string ExportsPath() {
            return (string) interceptor.Invoke("exportsPath", "exportsPath() const", typeof(string));
        }
        /// <remarks>
        ///  Returns the one and only instance of KNFSShare
        ///    </remarks>        <short>    Returns the one and only instance of KNFSShare    </short>
        public static KNFSShare Instance() {
            return (KNFSShare) staticInterceptor.Invoke("instance", "instance()", typeof(KNFSShare));
        }
        protected new IKNFSShareSignals Emit {
            get { return (IKNFSShareSignals) Q_EMIT; }
        }
    }

    public interface IKNFSShareSignals : IQObjectSignals {
    }
}
