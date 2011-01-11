/*
 *   Copyright 2008 by Richard Dale <richard.j.dale@gmail.com>
 *   Copyright 2008, Arno Rehn <arno@arnorehn.de>
 *
 *   This program is free software; you can redistribute it and/or modify
 *   it under the terms of the GNU Library General Public License as
 *   published by the Free Software Foundation; either version 2, or
 *   (at your option) any later version.
 *
 *   This program is distributed in the hope that it will be useful,
 *   but WITHOUT ANY WARRANTY; without even the implied warranty of
 *   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *   GNU General Public License for more details
 *
 *   You should have received a copy of the GNU Library General Public
 *   License along with this program; if not, write to the
 *   Free Software Foundation, Inc.,
 *   51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
 */

namespace PlasmaScripting {
    using Plasma;
    using System;
    using Kimono;
    using Qyoto;
    using System.Collections.Generic;
    /// <remarks>
    ///  @class DataEngine
    ///  @brief Data provider for plasmoids (Plasma plugins)
    ///  This is the base class for DataEngines, which provide access to bodies of
    ///  data via a common and consistent interface. The common use of a DataEngine
    ///  is to provide data to a widget for display. This allows a user interface
    ///  element to show all sorts of data: as long as there is a DataEngine, the
    ///  data is retrievable.
    ///  DataEngines are loaded as plugins on demand and provide zero, one or more
    ///  data sources which are identified by name. For instance, a network
    ///  DataEngine might provide a data source for each network interface.
    ///  See <see cref="IDataEngineSignals"></see> for signals emitted by DataEngine
    /// </remarks>        <short>    @class DataEngine  @brief Data provider for plasmoids (Plasma plugins) </short>
    public class DataEngine : QObject, IDisposable {
        private DataEngineScript dataEngineScript;
        private Plasma.DataEngine dataEngine;
        private Type dataEngineType;

        public Plasma.DataEngine PlasmaDataEngine {
            get { return dataEngine; }
        }
        [Q_PROPERTY("bool", "valid")]
        public bool Valid {
            get { return dataEngine.Valid; }
        }
        [Q_PROPERTY("QString", "icon")]
        public string icon {
            get { return dataEngine.icon; }
            set { dataEngine.icon = value; }
        }
        /// <remarks>
        ///  Constructor.
        /// <param> name="parent" The parent object.
        /// </param></remarks>        <short>    Constructor.</short>
        public DataEngine(DataEngineScript parent) : base(parent) {
            dataEngineScript = parent;
            dataEngine = parent.DataEngine();
            dataEngineType = dataEngine.GetType();
            Connect(dataEngine, SIGNAL("sourceAdded(QString)"), this, SIGNAL("sourceAdded(QString)"));
            Connect(dataEngine, SIGNAL("sourceRemoved(QString)"), this, SIGNAL("sourceRemoved(QString)"));
        }
        /// <remarks>
        ///  This method is called when the DataEngine is started. When this
        ///  method is called the DataEngine is fully constructed and ready to be
        ///  used. This method should be reimplemented by DataEngine subclasses
        ///  which have the need to perform a startup routine.
        /// </remarks>        <short>    This method is called when the DataEngine is started.</short>
        public virtual void Init() {
        }
        /// <remarks>
        /// </remarks>        <return> a list of all the data sources available via this DataEngine
        ///          Whether these sources are currently available (which is what
        ///          the default implementation provides) or not is up to the
        ///          DataEngine to decide.
        /// </return>
        ///         <short>   </short>
        public virtual List<string> Sources() {
            return new List<string>();
        }
        /// <remarks>
        /// <param> name="source" the source to target the Service at
        /// </param></remarks>        <return> a Service that has the source as a destination. The service
        ///          is parented to the DataEngine, but may be deleted by the
        ///          caller when finished with it
        ///          </return>
        ///         <short>   </short>
        /// <remarks>
        ///  Returns the engine name for the DataEngine
        ///          </remarks>        <short>    Returns the engine name for the DataEngine          </short>
        public string Name() {
            return dataEngine.Name();
        }
        /// <remarks>
        ///  Connects a source to an object for data updates. The object must
        ///  have a slot with the following signature:
        ///  dataUpdated(stringsourceName, const Plasma.DataEngine.Data &data)
        ///  The data is a QHash of QVariants keyed by string names, allowing
        ///  one data source to provide sets of related data.
        /// <param> name="source" the name of the data source
        /// </param><param> name="visualization" the object to connect the data source to
        /// </param><param> name="pollingInterval" the frequency, in milliseconds, with which to check for updates;
        ///                         a value of 0 (the default) means to update only
        ///                         when there is new data spontaneously generated
        ///                         (e.g. by the engine); any other value results in
        ///                         periodic updates from this source. This value is
        ///                         per-visualization and can be handy for items that require
        ///                         constant updates such as scrolling graphs or clocks.
        ///                         If the data has not changed, no update will be sent.
        /// </param><param> name="intervalAlignment" the number of ms to align the interval to
        /// </param></remarks>        <short>    Connects a source to an object for data updates.</short>
        public void ConnectSource(string source, QObject visualization, uint pollingInterval, Plasma.IntervalAlignment intervalAlignment) {
            dataEngine.ConnectSource(source, visualization, pollingInterval, intervalAlignment);
        }
        public void ConnectSource(string source, QObject visualization, uint pollingInterval) {
            dataEngine.ConnectSource(source, visualization, pollingInterval);
        }
        public void ConnectSource(string source, QObject visualization) {
            dataEngine.ConnectSource(source, visualization);
        }
        /// <remarks>
        ///  Connects all currently existing sources to an object for data updates.
        ///  The object must have a slot with the following signature:
        ///  SLOT("dataUpdated(string,Plasma.DataEngine.Data)")
        ///  The data is a QHash of QVariants keyed by string names, allowing
        ///  one data source to provide sets of related data.
        ///  This method may be called multiple times for the same visualization
        ///  without side-effects. This can be useful to change the pollingInterval.
        ///  Note that this method does not automatically connect sources that
        ///  may appear later on. Connecting and responding to the sourceAdded sigal
        ///  is still required to achieve that.
        /// <param> name="visualization" the object to connect the data source to
        /// </param><param> name="pollingInterval" the frequency, in milliseconds, with which to check for updates;
        ///                         a value of 0 (the default) means to update only
        ///                         when there is new data spontaneously generated
        ///                         (e.g. by the engine); any other value results in
        ///                         periodic updates from this source. This value is
        ///                         per-visualization and can be handy for items that require
        ///                         constant updates such as scrolling graphs or clocks.
        ///                         If the data has not changed, no update will be sent.
        /// </param><param> name="intervalAlignment" the number of ms to align the interval to
        /// </param></remarks>        <short>    Connects all currently existing sources to an object for data updates.</short>
        public void ConnectAllSources(QObject visualization, uint pollingInterval, Plasma.IntervalAlignment intervalAlignment) {
            dataEngine.ConnectAllSources(visualization, pollingInterval, intervalAlignment);
        }
        public void ConnectAllSources(QObject visualization, uint pollingInterval) {
            dataEngine.ConnectAllSources(visualization, pollingInterval);
        }
        public void ConnectAllSources(QObject visualization) {
            dataEngine.ConnectAllSources(visualization);
        }
        /// <remarks>
        ///  Disconnects a source to an object that was receiving data updates.
        /// <param> name="source" the name of the data source
        /// </param><param> name="visualization" the object to connect the data source to
        /// </param></remarks>        <short>    Disconnects a source to an object that was receiving data updates.</short>
        public void DisconnectSource(string source, QObject visualization) {
            dataEngine.DisconnectSource(source, visualization);
        }
        /// <remarks>
        ///  Retrevies a pointer to the DataContainer for a given source. This method
        ///  should not be used if possible. An exception is for script engines that
        ///  can not provide a QMetaObject as required by connectSource for the initial
        ///  call to dataUpdated. Using this method, such engines can provide their own
        ///  connectSource API.
        /// <param> name="source" the name of the source.
        /// </param></remarks>        <return> pointer to a DataContainer, or zero on failure
        /// </return>
        ///         <short>    Retrevies a pointer to the DataContainer for a given source.</short>
        public Plasma.DataContainer ContainerForSource(string source) {
            return dataEngine.ContainerForSource(source);
        }
        /// <remarks>
        ///  Gets the Data associated with a data source.
        ///  The data is a QHash of QVariants keyed by string names, allowing
        ///  one data source to provide sets of related data.
        /// <param> name="source" the data source to retrieve the data for
        /// </param></remarks>        <return> the Data associated with the source; if the source doesn't
        ///          exist an empty data set is returned
        /// </return>
        ///         <short>    Gets the Data associated with a data source.</short>
        public Dictionary<string, QVariant> Query(string source) {
            return dataEngine.Query(source);
        }
        /// <remarks>
        ///  Returns true if the data engine is empty, which is to say that it has no
        ///  data sources currently.
        ///          </remarks>        <short>    Returns true if the data engine is empty, which is to say that it has no  data sources currently.</short>
        public bool IsEmpty() {
            return dataEngine.IsEmpty();
        }
        /// <remarks>
        ///  Returns the maximum number of sources this DataEngine will have
        ///  at any given time.
        /// </remarks>        <return> the maximum number of sources; zero means no limit.
        ///          </return>
        ///         <short>    Returns the maximum number of sources this DataEngine will have  at any given time.</short>
        public uint MaxSourceCount() {
            return dataEngine.MaxSourceCount();
        }
        /// <remarks>
        ///  Accessor for the associated Package object if any.
        /// </remarks>        <return> the Package object, or 0 if none
        /// </return>
        ///         <short>    Accessor for the associated Package object if any.</short>
        public Plasma.Package Package() {
            return dataEngine.Package();
        }
        /// <remarks>
        ///  When a source that does not currently exist is requested by the
        ///  consumer, this method is called to give the DataEngine the
        ///  opportunity to create one.
        ///  The name of the data source (e.g. the source parameter passed into
        ///  setData) must be the same as the name passed to sourceRequestEvent
        ///  otherwise the requesting visualization may not receive notice of a
        ///  data update.
        ///  If the source can not be populated with data immediately (e.g. due to
        ///  an asynchronous data acquisition method such as an HTTP request)
        ///  the source must still be created, even if it is empty. This can
        ///  be accomplished in these cases with the follow line:
        ///       setData(name, DataEngine.Data());
        /// <param> name="source" the name of the source that has been requested
        /// </param></remarks>        <return> true if a DataContainer was set up, false otherwise
        ///          </return>
        ///         <short>    When a source that does not currently exist is requested by the  consumer, this method is called to give the DataEngine the  opportunity to create one.</short>
        public virtual bool SourceRequestEvent(string source) {
            return false;
        }
        /// <remarks>
        ///  Called by internal updating mechanisms to trigger the engine
        ///  to refresh the data contained in a given source. Reimplement this
        ///  method when using facilities such as setPollingInterval.
        /// <param> name="source" the name of the source that should be updated
        /// </param></remarks>        <return> true if the data was changed, or false if there was no
        ///          change or if the change will occur later
        /// </return>
        ///         <short>    Called by internal updating mechanisms to trigger the engine  to refresh the data contained in a given source.</short>
        ///         <see> setPollingInterval</see>
        public virtual bool UpdateSourceEvent(string source) {
            return false;
        }
        /// <remarks>
        ///  Sets a value for a data source. If the source
        ///  doesn't exist then it is created.
        /// <param> name="source" the name of the data source
        /// </param><param> name="value" the data to associated with the source
        /// </param></remarks>        <short>    Sets a value for a data source.</short>
        protected void SetData(string source, QVariant value) {
            dataEngineScript.SetData(source, value);
        }
        /// <remarks>
        ///  Sets a value for a data source. If the source
        ///  doesn't exist then it is created.
        /// <param> name="source" the name of the data source
        /// </param><param> name="key" the key to use for the data
        /// </param><param> name="value" the data to associated with the source
        /// </param></remarks>        <short>    Sets a value for a data source.</short>
        protected void SetData(string source, string key, QVariant value) {
            dataEngineScript.SetData(source, key, value);
        }
        /// <remarks>
        ///  Adds a set of data to a data source. If the source
        ///  doesn't exist then it is created.
        /// <param> name="source" the name of the data source
        /// </param><param> name="data" the data to add to the source
        /// </param></remarks>        <short>    Adds a set of data to a data source.</short>
        protected void SetData(string source, Dictionary<string, QVariant> data) {
            // dataEngine.SetData(source, data);
        }
        /// <remarks>
        ///  Removes all the data associated with a data source.
        /// <param> name="source" the name of the data source
        /// </param></remarks>        <short>    Removes all the data associated with a data source.</short>
        protected void RemoveAllData(string source) {
            dataEngineScript.RemoveAllData(source);
        }
        /// <remarks>
        ///  Removes a data entry from a source
        /// <param> name="source" the name of the data source
        /// </param><param> name="key" the data entry to remove
        /// </param></remarks>        <short>    Removes a data entry from a source </short>
        protected void RemoveData(string source, string key) {
            dataEngineScript.RemoveData(source, key);
        }
        /// <remarks>
        ///  Adds an already constructed data source. The DataEngine takes
        ///  ownership of the DataContainer object.
        /// <param> name="source" the DataContainer to add to the DataEngine
        /// </param></remarks>        <short>    Adds an already constructed data source.</short>
        protected void AddSource(Plasma.DataContainer source) {
            Object[] parameters = new Object[1];
            parameters[0] = source;
            dataEngineType.GetMethod("AddSource").Invoke(dataEngine, parameters);
        }
        /// <remarks>
        ///  Sets an upper limit on the number of data sources to keep in this engine.
        ///  If the limit is exceeded, then the oldest data source, as defined by last
        ///  update, is dropped.
        /// <param> name="limit" the maximum number of sources to keep active
        /// </param></remarks>        <short>    Sets an upper limit on the number of data sources to keep in this engine.</short>
        protected void SetMaxSourceCount(uint limit) {
            dataEngineScript.SetMaxSourceCount(limit);
        }
        /// <remarks>
        ///  Sets the minimum amount of time, in milliseconds, that must pass between
        ///  successive updates of data. This can help prevent too many updates happening
        ///  due to multiple update requests coming in, which can be useful for
        ///  expensive (time- or resource-wise) update mechanisms.
        /// <param> name="minimumMs" the minimum time lapse, in milliseconds, between updates.
        ///                 A value less than 0 means to never perform automatic updates,
        ///                 a value of 0 means update immediately on every update request,
        ///                 a value >0 will result in a minimum time lapse being enforced.
        /// </param></remarks>        <short>    Sets the minimum amount of time, in milliseconds, that must pass between  successive updates of data.</short>
        protected void SetMinimumPollingInterval(int minimumMs) {
            dataEngineScript.SetMinimumPollingInterval(minimumMs);
        }
        /// <remarks>
        /// </remarks>        <return> the minimum time between updates. @see setMinimumPollingInterval
        /// </return>
        ///         <short>   </short>
        protected int MinimumPollingInterval() {
            return dataEngineScript.MinimumPollingInterval();
        }
        /// <remarks>
        ///  Sets up an internal update tick for all data sources. On every update,
        ///  updateSourceEvent will be called for each applicable source.
        /// <param> name="frequency" the time, in milliseconds, between updates. A value of 0
        ///                   will stop internally triggered updates.
        /// </param></remarks>        <short>    Sets up an internal update tick for all data sources.</short>
        ///         <see> updateSourceEvent</see>
        protected void SetPollingInterval(uint frequency) {
            dataEngineScript.SetPollingInterval(frequency);
        }
        /// <remarks>
        ///  Removes all data sources
        /// </remarks>        <short>    Removes all data sources </short>
        protected void RemoveAllSources() {
            dataEngineScript.RemoveAllSources();
        }
        /// <remarks>
        /// </remarks>        <return> the list of active DataContainers.
        ///          </return>
        ///         <short>   </short>
        protected Dictionary<string, Plasma.DataContainer> ContainerDict() {
            return new Dictionary<string, Plasma.DataContainer>();
        }
        /// <remarks>
        ///  Reimplemented from QObject
        /// </remarks>        <short>    Reimplemented from QObject </short>
        protected override void TimerEvent(QTimerEvent arg1) {
        }
        /// <remarks>
        ///  Sets the engine name for the DataEngine
        ///          </remarks>        <short>    Sets the engine name for the DataEngine          </short>
        protected void SetName(string name) {
            Object[] parameters = new Object[1];
            parameters[0] = name;
            dataEngineType.GetMethod("SetName").Invoke(dataEngine, parameters);
        }
        /// <remarks>
        ///  Call this method when you call setData directly on a DataContainer instead
        ///  of using the DataEngine.SetData methods.
        ///  If this method is not called, no dataUpdated(..) signals will be emitted!
        ///          </remarks>        <short>    Call this method when you call setData directly on a DataContainer instead  of using the DataEngine.SetData methods.</short>
        [Q_SLOT("void scheduleSourcesUpdated()")]
        protected void ScheduleSourcesUpdated() {
            dataEngineType.GetMethod("ScheduleSourcesUpdated").Invoke(dataEngine, null);
        }
        /// <remarks>
        ///  Removes a data source.
        /// <param> name="source" the name of the data source to remove
        /// </param></remarks>        <short>    Removes a data source.</short>
        [Q_SLOT("void removeSource(const QString&)")]
        protected void RemoveSource(string source) {
            Object[] parameters = new Object[1];
            parameters[0] = source;
            dataEngineType.GetMethod("RemoveSource").Invoke(dataEngine, parameters);
        }
        /// <remarks>
        ///  Immediately updates all existing sources when called
        ///          </remarks>        <short>    Immediately updates all existing sources when called          </short>
        [Q_SLOT("void updateAllSources()")]
        protected void UpdateAllSources() {
            dataEngineType.GetMethod("UpdateAllSources").Invoke(dataEngine, null);
        }
        ~DataEngine() {
        }
        public new void Dispose() {
        }
        protected new IDataEngineSignals Emit {
            get { return (IDataEngineSignals) Q_EMIT; }
        }
    }

    public interface IDataEngineSignals : IQObjectSignals {
        /// <remarks>
        ///  Emitted when a new data source is created
        /// <param> name="source" the name of the new data source
        /// </param></remarks>        <short>    Emitted when a new data source is created </short>
        [Q_SIGNAL("void sourceAdded(QString)")]
        void SourceAdded(string source);
        /// <remarks>
        ///  Emitted when a data source is removed.
        /// <param> name="source" the name of the data source that was removed
        /// </param></remarks>        <short>    Emitted when a data source is removed.</short>
        [Q_SIGNAL("void sourceRemoved(QString)")]
        void SourceRemoved(string source);
    }
}

// kate: space-indent on; indent-width 4; replace-tabs on; mixed-indent off;

