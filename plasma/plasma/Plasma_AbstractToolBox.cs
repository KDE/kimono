//Auto-generated by kalyptus. DO NOT EDIT.
namespace Plasma {
    using Plasma;
    using System;
    using Kimono;
    using Qyoto;
    /// <remarks> See <see cref="IAbstractToolBoxSignals"></see> for signals emitted by AbstractToolBox
    /// </remarks>
    [SmokeClass("Plasma::AbstractToolBox")]
    public abstract class AbstractToolBox : QGraphicsWidget {
        protected AbstractToolBox(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(AbstractToolBox), this);
        }
        public enum ToolType {
            AddTool = 0,
            ConfigureTool = 100,
            ControlTool = 200,
            MiscTool = 300,
            DestructiveTool = 400,
            UserToolType = DestructiveTool+1000,
        }
        [Q_PROPERTY("bool", "showing")]
        public bool Showing {
            get { return (bool) interceptor.Invoke("isShowing", "isShowing()", typeof(bool)); }
            set { interceptor.Invoke("setShowing$", "setShowing(bool)", typeof(void), typeof(bool), value); }
        }
        public AbstractToolBox(Plasma.Containment parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("AbstractToolBox#", "AbstractToolBox(Plasma::Containment*)", typeof(void), typeof(Plasma.Containment), parent);
        }
        /// <remarks>
        ///  create a toolbox tool from the given action
        ///  <code>action</code> the action to associate the tool with
        ///      </remarks>        <short>    create a toolbox tool from the given action  <code>action</code> the action to associate the tool with      </short>
        [SmokeMethod("addTool(QAction*)")]
        public abstract void AddTool(QAction action);
        /// <remarks>
        ///  remove the tool associated with this action
        ///      </remarks>        <short>    remove the tool associated with this action      </short>
        [SmokeMethod("removeTool(QAction*)")]
        public abstract void RemoveTool(QAction action);
        [SmokeMethod("isShowing() const")]
        public abstract bool IsShowing();
        [SmokeMethod("setShowing(const bool)")]
        public abstract void SetShowing(bool show);
        protected Plasma.Containment Containment() {
            return (Plasma.Containment) interceptor.Invoke("containment", "containment() const", typeof(Plasma.Containment));
        }
        protected new IAbstractToolBoxSignals Emit {
            get { return (IAbstractToolBoxSignals) Q_EMIT; }
        }
    }

    public interface IAbstractToolBoxSignals : IQGraphicsWidgetSignals {
        [Q_SIGNAL("void toggled()")]
        void Toggled();
        [Q_SIGNAL("void visibilityChanged(bool)")]
        void VisibilityChanged(bool arg1);
    }
}
