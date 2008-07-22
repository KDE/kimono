//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
    using System;
    using Qyoto;
    /// <remarks>
    ///  This class extends KCoreConfigSkeleton by support for GUI types.
    ///  </remarks>        <author> Cornelius Schumacher
    /// </author>
    ///         <short> Class for handling preferences settings for an application. </short>
    [SmokeClass("KConfigSkeleton")]
    public class KConfigSkeleton : KCoreConfigSkeleton, IDisposable {
        protected KConfigSkeleton(Type dummy) : base((Type) null) {}
        /// <remarks>
        ///  Class for handling a color preferences item.
        ///    </remarks>        <short>    Class for handling a color preferences item.</short>
        [SmokeClass("KConfigSkeleton::ItemColor")]
        public class ItemColor : KConfigSkeletonGenericItem, IDisposable {
            protected ItemColor(Type dummy) : base((Type) null) {}
            protected new void CreateProxy() {
                interceptor = new SmokeInvocation(typeof(ItemColor), this);
            }
            /// <remarks> @copydoc KConfigSkeletonGenericItem.KConfigSkeletonGenericItem </remarks>        <short>   @copydoc KConfigSkeletonGenericItem.KConfigSkeletonGenericItem </short>
            public ItemColor(string _group, string _key, QColor reference, QColor defaultValue) : this((Type) null) {
                CreateProxy();
                interceptor.Invoke("ItemColor$$##", "ItemColor(const QString&, const QString&, QColor&, const QColor&)", typeof(void), typeof(string), _group, typeof(string), _key, typeof(QColor), reference, typeof(QColor), defaultValue);
            }
            public ItemColor(string _group, string _key, QColor reference) : this((Type) null) {
                CreateProxy();
                interceptor.Invoke("ItemColor$$#", "ItemColor(const QString&, const QString&, QColor&)", typeof(void), typeof(string), _group, typeof(string), _key, typeof(QColor), reference);
            }
            /// <remarks> @copydoc KConfigSkeletonItem.ReadConfig(KConfig) </remarks>        <short>   @copydoc KConfigSkeletonItem.ReadConfig(KConfig ) </short>
            public void ReadConfig(KConfig config) {
                interceptor.Invoke("readConfig#", "readConfig(KConfig*)", typeof(void), typeof(KConfig), config);
            }
            /// <remarks> @copydoc KConfigSkeletonItem.SetProperty(QVariant) </remarks>        <short>   @copydoc KConfigSkeletonItem.SetProperty(QVariant) </short>
            public void SetProperty(QVariant p) {
                interceptor.Invoke("setProperty#", "setProperty(const QVariant&)", typeof(void), typeof(QVariant), p);
            }
            /// <remarks> @copydoc KConfigSkeletonItem.IsEqual(QVariant) </remarks>        <short>   @copydoc KConfigSkeletonItem.IsEqual(QVariant) </short>
            public bool IsEqual(QVariant p) {
                return (bool) interceptor.Invoke("isEqual#", "isEqual(const QVariant&) const", typeof(bool), typeof(QVariant), p);
            }
            /// <remarks> @copydoc KConfigSkeletonItem.Property() </remarks>        <short>   @copydoc KConfigSkeletonItem.Property() </short>
            public QVariant Property() {
                return (QVariant) interceptor.Invoke("property", "property() const", typeof(QVariant));
            }
            ~ItemColor() {
                interceptor.Invoke("~ItemColor", "~ItemColor()", typeof(void));
            }
            public void Dispose() {
                interceptor.Invoke("~ItemColor", "~ItemColor()", typeof(void));
            }
        }
        /// <remarks>
        ///  Class for handling a font preferences item.
        ///    </remarks>        <short>    Class for handling a font preferences item.</short>
        [SmokeClass("KConfigSkeleton::ItemFont")]
        public class ItemFont : KConfigSkeletonGenericItem, IDisposable {
            protected ItemFont(Type dummy) : base((Type) null) {}
            protected new void CreateProxy() {
                interceptor = new SmokeInvocation(typeof(ItemFont), this);
            }
            /// <remarks> @copydoc KConfigSkeletonGenericItem.KConfigSkeletonGenericItem </remarks>        <short>   @copydoc KConfigSkeletonGenericItem.KConfigSkeletonGenericItem </short>
            public ItemFont(string _group, string _key, QFont reference, QFont defaultValue) : this((Type) null) {
                CreateProxy();
                interceptor.Invoke("ItemFont$$##", "ItemFont(const QString&, const QString&, QFont&, const QFont&)", typeof(void), typeof(string), _group, typeof(string), _key, typeof(QFont), reference, typeof(QFont), defaultValue);
            }
            public ItemFont(string _group, string _key, QFont reference) : this((Type) null) {
                CreateProxy();
                interceptor.Invoke("ItemFont$$#", "ItemFont(const QString&, const QString&, QFont&)", typeof(void), typeof(string), _group, typeof(string), _key, typeof(QFont), reference);
            }
            /// <remarks> @copydoc KConfigSkeletonItem.ReadConfig(KConfig) </remarks>        <short>   @copydoc KConfigSkeletonItem.ReadConfig(KConfig ) </short>
            public void ReadConfig(KConfig config) {
                interceptor.Invoke("readConfig#", "readConfig(KConfig*)", typeof(void), typeof(KConfig), config);
            }
            /// <remarks> @copydoc KConfigSkeletonItem.SetProperty(QVariant) </remarks>        <short>   @copydoc KConfigSkeletonItem.SetProperty(QVariant) </short>
            public void SetProperty(QVariant p) {
                interceptor.Invoke("setProperty#", "setProperty(const QVariant&)", typeof(void), typeof(QVariant), p);
            }
            /// <remarks> @copydoc KConfigSkeletonItem.IsEqual(QVariant) </remarks>        <short>   @copydoc KConfigSkeletonItem.IsEqual(QVariant) </short>
            public bool IsEqual(QVariant p) {
                return (bool) interceptor.Invoke("isEqual#", "isEqual(const QVariant&) const", typeof(bool), typeof(QVariant), p);
            }
            /// <remarks> @copydoc KConfigSkeletonItem.Property() </remarks>        <short>   @copydoc KConfigSkeletonItem.Property() </short>
            public QVariant Property() {
                return (QVariant) interceptor.Invoke("property", "property() const", typeof(QVariant));
            }
            ~ItemFont() {
                interceptor.Invoke("~ItemFont", "~ItemFont()", typeof(void));
            }
            public void Dispose() {
                interceptor.Invoke("~ItemFont", "~ItemFont()", typeof(void));
            }
        }
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(KConfigSkeleton), this);
        }
        /// <remarks>
        ///  Constructor.
        /// <param> name="configname" name of config file. If no name is given, the default
        ///  config file as returned by KGlobal.Config() is used.
        ///    </param></remarks>        <short>    Constructor.</short>
        public KConfigSkeleton(string configname, QObject parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KConfigSkeleton$#", "KConfigSkeleton(const QString&, QObject*)", typeof(void), typeof(string), configname, typeof(QObject), parent);
        }
        public KConfigSkeleton(string configname) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KConfigSkeleton$", "KConfigSkeleton(const QString&)", typeof(void), typeof(string), configname);
        }
        public KConfigSkeleton() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KConfigSkeleton", "KConfigSkeleton()", typeof(void));
        }
        /// <remarks>
        ///  Constructor.
        /// <param> name="config" configuration object to use.
        ///    </param></remarks>        <short>    Constructor.</short>
        public KConfigSkeleton(KSharedConfig config, QObject parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KConfigSkeleton?#", "KConfigSkeleton(KSharedPtr<KSharedConfig>, QObject*)", typeof(void), typeof(KSharedConfig), config, typeof(QObject), parent);
        }
        public KConfigSkeleton(KSharedConfig config) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KConfigSkeleton?", "KConfigSkeleton(KSharedPtr<KSharedConfig>)", typeof(void), typeof(KSharedConfig), config);
        }
        /// <remarks>
        ///  Register an item of type QColor.
        /// <param> name="name" Name used to identify this setting. Names must be unique.
        /// </param><param> name="reference" Pointer to the variable, which is set by readConfig()
        ///  calls and read by writeConfig() calls.
        /// </param><param> name="defaultValue" Default value, which is used when the config file
        ///  does not yet contain the key of this item.
        /// </param><param> name="key" Key used in config file. If key is null, name is used as key.
        /// </param></remarks>        <return> The created item
        ///    </return>
        ///         <short>    Register an item of type QColor.</short>
        public KConfigSkeleton.ItemColor AddItemColor(string name, QColor reference, QColor defaultValue, string key) {
            return (KConfigSkeleton.ItemColor) interceptor.Invoke("addItemColor$##$", "addItemColor(const QString&, QColor&, const QColor&, const QString&)", typeof(KConfigSkeleton.ItemColor), typeof(string), name, typeof(QColor), reference, typeof(QColor), defaultValue, typeof(string), key);
        }
        public KConfigSkeleton.ItemColor AddItemColor(string name, QColor reference, QColor defaultValue) {
            return (KConfigSkeleton.ItemColor) interceptor.Invoke("addItemColor$##", "addItemColor(const QString&, QColor&, const QColor&)", typeof(KConfigSkeleton.ItemColor), typeof(string), name, typeof(QColor), reference, typeof(QColor), defaultValue);
        }
        public KConfigSkeleton.ItemColor AddItemColor(string name, QColor reference) {
            return (KConfigSkeleton.ItemColor) interceptor.Invoke("addItemColor$#", "addItemColor(const QString&, QColor&)", typeof(KConfigSkeleton.ItemColor), typeof(string), name, typeof(QColor), reference);
        }
        /// <remarks>
        ///  Register an item of type QFont.
        /// <param> name="name" Name used to identify this setting. Names must be unique.
        /// </param><param> name="reference" Pointer to the variable, which is set by readConfig()
        ///  calls and read by writeConfig() calls.
        /// </param><param> name="defaultValue" Default value, which is used when the config file
        ///  does not yet contain the key of this item.
        /// </param><param> name="key" Key used in config file. If key is null, name is used as key.
        /// </param></remarks>        <return> The created item
        ///    </return>
        ///         <short>    Register an item of type QFont.</short>
        public KConfigSkeleton.ItemFont AddItemFont(string name, QFont reference, QFont defaultValue, string key) {
            return (KConfigSkeleton.ItemFont) interceptor.Invoke("addItemFont$##$", "addItemFont(const QString&, QFont&, const QFont&, const QString&)", typeof(KConfigSkeleton.ItemFont), typeof(string), name, typeof(QFont), reference, typeof(QFont), defaultValue, typeof(string), key);
        }
        public KConfigSkeleton.ItemFont AddItemFont(string name, QFont reference, QFont defaultValue) {
            return (KConfigSkeleton.ItemFont) interceptor.Invoke("addItemFont$##", "addItemFont(const QString&, QFont&, const QFont&)", typeof(KConfigSkeleton.ItemFont), typeof(string), name, typeof(QFont), reference, typeof(QFont), defaultValue);
        }
        public KConfigSkeleton.ItemFont AddItemFont(string name, QFont reference) {
            return (KConfigSkeleton.ItemFont) interceptor.Invoke("addItemFont$#", "addItemFont(const QString&, QFont&)", typeof(KConfigSkeleton.ItemFont), typeof(string), name, typeof(QFont), reference);
        }
        ~KConfigSkeleton() {
            interceptor.Invoke("~KConfigSkeleton", "~KConfigSkeleton()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~KConfigSkeleton", "~KConfigSkeleton()", typeof(void));
        }
        protected new IKConfigSkeletonSignals Emit {
            get { return (IKConfigSkeletonSignals) Q_EMIT; }
        }
    }

    public interface IKConfigSkeletonSignals : IKCoreConfigSkeletonSignals {
    }
}
