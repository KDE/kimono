//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	///<remarks>*************************************************
	/// $Id: qt/qsignal.h   3.3.5   edited Aug 31 12:17 $
	///
	///* Definition of QSignal class
	///
	///* Created : 941201
	///
	///* Copyright (C) 1992-2005 Trolltech AS.  All rights reserved.
	///
	///* This file is part of the kernel module of the Qt GUI Toolkit.
	///
	///* This file may be distributed under the terms of the Q Public License
	/// as defined by Trolltech AS of Norway and appearing in the file
	/// LICENSE.QPL included in the packaging of this file.
	///
	///* This file may be distributed and/or modified under the terms of the
	/// GNU General Public License version 2 as published by the Free Software
	/// Foundation and appearing in the file LICENSE.GPL included in the
	/// packaging of this file.
	///
	///* Licensees holding valid Qt Enterprise Edition or Qt Professional Edition
	/// licenses may use this file in accordance with the Qt Commercial License
	/// Agreement provided with the Software.
	///
	///* This file is provided AS IS with NO WARRANTY OF ANY KIND, INCLUDING THE
	/// WARRANTY OF DESIGN, MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE.
	///
	///* See http://www.trolltech.com/pricing.html or email sales@trolltech.com for
	///   information about Qt Commercial License Agreements.
	/// See http://www.trolltech.com/qpl/ for QPL licensing information.
	/// See http://www.trolltech.com/gpl/ for GPL licensing information.
	///
	///* Contact info@trolltech.com if any conditions of this licensing are
	/// not clear to you.
	///
	///********************************************** See <see cref="IQSignalSignals"></see> for signals emitted by QSignal
	///</remarks>		<short>                                                                               $Id: qt/qsignal.</short>

	[SmokeClass("QSignal")]
	public class QSignal : QObject, IDisposable {
 		protected QSignal(Type dummy) : base((Type) null) {}
		interface IQSignalProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QSignal), this);
			_interceptor = (QSignal) realProxy.GetTransparentProxy();
		}
		private QSignal ProxyQSignal() {
			return (QSignal) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QSignal() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQSignalProxy), null);
			_staticInterceptor = (IQSignalProxy) realProxy.GetTransparentProxy();
		}
		private static IQSignalProxy StaticQSignal() {
			return (IQSignalProxy) _staticInterceptor;
		}

		[SmokeMethod("metaObject() const")]
		public new virtual QMetaObject MetaObject() {
			return ProxyQSignal().MetaObject();
		}
		[SmokeMethod("className() const")]
		public new virtual string ClassName() {
			return ProxyQSignal().ClassName();
		}
		public QSignal(QObject parent, string name) : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQSignal(parent,name);
		}
		[SmokeMethod("QSignal(QObject*, const char*)")]
		private void NewQSignal(QObject parent, string name) {
			ProxyQSignal().NewQSignal(parent,name);
		}
		public QSignal(QObject parent) : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQSignal(parent);
		}
		[SmokeMethod("QSignal(QObject*)")]
		private void NewQSignal(QObject parent) {
			ProxyQSignal().NewQSignal(parent);
		}
		public QSignal() : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQSignal();
		}
		[SmokeMethod("QSignal()")]
		private void NewQSignal() {
			ProxyQSignal().NewQSignal();
		}
		[SmokeMethod("connect(const QObject*, const char*)")]
		public new bool Connect(QObject receiver, string member) {
			return ProxyQSignal().Connect(receiver,member);
		}
		[SmokeMethod("disconnect(const QObject*, const char*)")]
		public new bool Disconnect(QObject receiver, string member) {
			return ProxyQSignal().Disconnect(receiver,member);
		}
		[SmokeMethod("disconnect(const QObject*)")]
		public new bool Disconnect(QObject receiver) {
			return ProxyQSignal().Disconnect(receiver);
		}
		[SmokeMethod("activate()")]
		public void Activate() {
			ProxyQSignal().Activate();
		}
		[SmokeMethod("isBlocked() const")]
		public bool IsBlocked() {
			return ProxyQSignal().IsBlocked();
		}
		[SmokeMethod("block(bool)")]
		public void Block(bool b) {
			ProxyQSignal().Block(b);
		}
		[SmokeMethod("setParameter(int)")]
		public void SetParameter(int value) {
			ProxyQSignal().SetParameter(value);
		}
		[SmokeMethod("parameter() const")]
		public int Parameter() {
			return ProxyQSignal().Parameter();
		}
		[SmokeMethod("setValue(const QVariant&)")]
		public void SetValue(QVariant value) {
			ProxyQSignal().SetValue(value);
		}
		[SmokeMethod("value() const")]
		public QVariant Value() {
			return ProxyQSignal().Value();
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string arg1, string arg2) {
			return StaticQSignal().Tr(arg1,arg2);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string arg1) {
			return StaticQSignal().Tr(arg1);
		}
		[SmokeMethod("trUtf8(const char*, const char*)")]
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQSignal().TrUtf8(arg1,arg2);
		}
		[SmokeMethod("trUtf8(const char*)")]
		public static new string TrUtf8(string arg1) {
			return StaticQSignal().TrUtf8(arg1);
		}
		~QSignal() {
			DisposeQSignal();
		}
		public new void Dispose() {
			DisposeQSignal();
		}
		private void DisposeQSignal() {
			ProxyQSignal().DisposeQSignal();
		}
		protected new void CreateSignalProxy() {
			SignalInvocation realProxy = new SignalInvocation(typeof(IQSignalSignals), this);
			Q_EMIT = (IQSignalSignals) realProxy.GetTransparentProxy();
		}
		protected new IQSignalSignals Emit() {
			return (IQSignalSignals) Q_EMIT;
		}
	}

	public interface IQSignalSignals : IQObjectSignals {
		[Q_SIGNAL("void signal(const QVariant&)")]
		void Signal(QVariant arg1);
		[Q_SIGNAL("void intSignal(int)")]
		void IntSignal(int arg1);
	}
}
