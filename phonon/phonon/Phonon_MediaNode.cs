//Auto-generated by kalyptus. DO NOT EDIT.
namespace Phonon {
    using Phonon;
    using System;
    using Qyoto;
    using System.Collections.Generic;

    public interface IMediaNode {
        bool IsValid();
        List<Phonon.Path> InputPaths();
        List<Phonon.Path> OutputPaths();
    }
    [SmokeClass("Phonon::MediaNode")]
    public class MediaNode : Object, IMediaNode, IDisposable {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected MediaNode(Type dummy) {}
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(MediaNode), this);
        }
        // Phonon::MediaNode* MediaNode(Phonon::MediaNodePrivate& arg1); >>>> NOT CONVERTED
        /// <remarks>
        ///  Tells whether the backend provides an implementation of this
        ///  class.
        ///  \return <code>true</code> if backend provides an implementation
        ///  \return <code>false</code> if the object is not implemented by the backend
        ///          </remarks>        <short>    Tells whether the backend provides an implementation of this  class.</short>
        public bool IsValid() {
            return (bool) interceptor.Invoke("isValid", "isValid() const", typeof(bool));
        }
        public List<Phonon.Path> InputPaths() {
            return (List<Phonon.Path>) interceptor.Invoke("inputPaths", "inputPaths() const", typeof(List<Phonon.Path>));
        }
        public List<Phonon.Path> OutputPaths() {
            return (List<Phonon.Path>) interceptor.Invoke("outputPaths", "outputPaths() const", typeof(List<Phonon.Path>));
        }
        ~MediaNode() {
            interceptor.Invoke("~MediaNode", "~MediaNode()", typeof(void));
        }
        public void Dispose() {
            interceptor.Invoke("~MediaNode", "~MediaNode()", typeof(void));
        }
    }
}