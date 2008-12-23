//Auto-generated by kalyptus. DO NOT EDIT.
namespace QTest {
    using Qyoto;
    using System;
    using System.Collections.Generic;
    public enum SkipMode {
        SkipSingle = 1,
        SkipAll = 2,
    }
    public enum TestFailMode {
        Abort = 1,
        Continue = 2,
    }
    public enum MouseAction {
        MousePress = 0,
        MouseRelease = 1,
        MouseClick = 2,
        MouseDClick = 3,
        MouseMove = 4,
    }
    public enum KeyAction {
        Press = 0,
        Release = 1,
        Click = 2,
    }
    /// <remarks>*************************************************
    /// 
    /// * Copyright (C) 2008 Nokia Corporation and/or its subsidiary(-ies).
    ///  Contact: Qt Software Information (qt-info@nokia.com)
    /// 
    /// * This file is part of the QtTest module of the Qt Toolkit.
    /// 
    /// * Commercial Usage
    ///  Licensees holding valid Qt Commercial licenses may use this file in
    ///  accordance with the Qt Commercial License Agreement provided with the
    ///  Software or, alternatively, in accordance with the terms contained in
    ///  a written agreement between you and Nokia.
    /// 
    /// *
    ///  GNU General Public License Usage
    ///  Alternatively, this file may be used under the terms of the GNU
    ///  General Public License versions 2.0 or 3.0 as published by the Free
    ///  Software Foundation and appearing in the file LICENSE.GPL included in
    ///  the packaging of this file.  Please review the following information
    ///  to ensure GNU General Public Licensing requirements will be met:
    ///  http://www.fsf.org/licensing/licenses/info/GPLv2.html and
    ///  http://www.gnu.org/copyleft/gpl.html.  In addition, as a special
    ///  exception, Nokia gives you certain additional rights. These rights
    ///  are described in the Nokia Qt GPL Exception version 1.3, included in
    ///  the file GPL_EXCEPTION.txt in this package.
    /// 
    /// * Qt for Windows(R) Licensees
    ///  As a special exception, Nokia, as the sole copyright holder for Qt
    ///  Designer, grants users of the Qt/Eclipse Integration plug-in the
    ///  right for the Qt/Eclipse Integration to link to functionality
    ///  provided by Qt Designer and its related libraries.
    /// 
    /// * If you are unsure which license is appropriate for your use, please
    ///  contact the sales department at qt-sales@nokia.com.
    /// 
    /// **************************************************</remarks>        <short>                                                                                 Copyright (C) 2008 Nokia Corporation and/or its subsidiary(-ies).</short>
    [SmokeClass("QTest")]
    public class Global {
        private static SmokeInvocation staticInterceptor = null;
        static Global() {
            staticInterceptor = new SmokeInvocation(typeof(Global), null);
        }
        // char* toString(const void* arg1); >>>> NOT CONVERTED
        // void ignoreMessage(QtMsgType arg1,const char* arg2); >>>> NOT CONVERTED
        // void* qData(const char* arg1,int arg2); >>>> NOT CONVERTED
        // void* qGlobalData(const char* arg1,int arg2); >>>> NOT CONVERTED
        // void* qElementData(const char* arg1,int arg2); >>>> NOT CONVERTED
        // bool compare_ptr_helper(const void* arg1,const void* arg2,const char* arg3,const char* arg4,const char* arg5,int arg6); >>>> NOT CONVERTED
        public static Pointer<sbyte> ToHexRepresentation(string ba, int length) {
            return (Pointer<sbyte>) staticInterceptor.Invoke("toHexRepresentation$$", "toHexRepresentation(const char*, int)", typeof(Pointer<sbyte>), typeof(string), ba, typeof(int), length);
        }
        public static Pointer<sbyte> ToString(string arg1) {
            return (Pointer<sbyte>) staticInterceptor.Invoke("toString$", "toString(const char*)", typeof(Pointer<sbyte>), typeof(string), arg1);
        }
        public static int QExec(QObject testObject, int argc, Pointer<sbyte> argv) {
            return (int) staticInterceptor.Invoke("qExec#$?", "qExec(QObject*, int, char**)", typeof(int), typeof(QObject), testObject, typeof(int), argc, typeof(Pointer<sbyte>), argv);
        }
        public static int QExec(QObject testObject, int argc) {
            return (int) staticInterceptor.Invoke("qExec#$", "qExec(QObject*, int)", typeof(int), typeof(QObject), testObject, typeof(int), argc);
        }
        public static int QExec(QObject testObject) {
            return (int) staticInterceptor.Invoke("qExec#", "qExec(QObject*)", typeof(int), typeof(QObject), testObject);
        }
        public static int QExec(QObject testObject, List<string> arguments) {
            return (int) staticInterceptor.Invoke("qExec#?", "qExec(QObject*, const QStringList&)", typeof(int), typeof(QObject), testObject, typeof(List<string>), arguments);
        }
        public static bool QVerify(bool statement, string statementStr, string description, string file, int line) {
            return (bool) staticInterceptor.Invoke("qVerify$$$$$", "qVerify(bool, const char*, const char*, const char*, int)", typeof(bool), typeof(bool), statement, typeof(string), statementStr, typeof(string), description, typeof(string), file, typeof(int), line);
        }
        public static void QFail(string statementStr, string file, int line) {
            staticInterceptor.Invoke("qFail$$$", "qFail(const char*, const char*, int)", typeof(void), typeof(string), statementStr, typeof(string), file, typeof(int), line);
        }
        public static void QSkip(string message, QTest.SkipMode mode, string file, int line) {
            staticInterceptor.Invoke("qSkip$$$$", "qSkip(const char*, QTest::SkipMode, const char*, int)", typeof(void), typeof(string), message, typeof(QTest.SkipMode), mode, typeof(string), file, typeof(int), line);
        }
        public static bool QExpectFail(string dataIndex, string comment, QTest.TestFailMode mode, string file, int line) {
            return (bool) staticInterceptor.Invoke("qExpectFail$$$$$", "qExpectFail(const char*, const char*, QTest::TestFailMode, const char*, int)", typeof(bool), typeof(string), dataIndex, typeof(string), comment, typeof(QTest.TestFailMode), mode, typeof(string), file, typeof(int), line);
        }
        public static void QWarn(string message) {
            staticInterceptor.Invoke("qWarn$", "qWarn(const char*)", typeof(void), typeof(string), message);
        }
        public static QObject TestObject() {
            return (QObject) staticInterceptor.Invoke("testObject", "testObject()", typeof(QObject));
        }
        public static string CurrentTestFunction() {
            return (string) staticInterceptor.Invoke("currentTestFunction", "currentTestFunction()", typeof(string));
        }
        public static string CurrentDataTag() {
            return (string) staticInterceptor.Invoke("currentDataTag", "currentDataTag()", typeof(string));
        }
        public static bool CurrentTestFailed() {
            return (bool) staticInterceptor.Invoke("currentTestFailed", "currentTestFailed()", typeof(bool));
        }
        public static Qt.Key AsciiToKey(char ascii) {
            return (Qt.Key) staticInterceptor.Invoke("asciiToKey$", "asciiToKey(char)", typeof(Qt.Key), typeof(char), ascii);
        }
        public static char KeyToAscii(Qt.Key key) {
            return (char) staticInterceptor.Invoke("keyToAscii$", "keyToAscii(Qt::Key)", typeof(char), typeof(Qt.Key), key);
        }
        public static bool Compare_helper(bool success, string msg, string file, int line) {
            return (bool) staticInterceptor.Invoke("compare_helper$$$$", "compare_helper(bool, const char*, const char*, int)", typeof(bool), typeof(bool), success, typeof(string), msg, typeof(string), file, typeof(int), line);
        }
        public static bool Compare_helper(bool success, string msg, Pointer<sbyte> val1, Pointer<sbyte> val2, string expected, string actual, string file, int line) {
            return (bool) staticInterceptor.Invoke("compare_helper$$$$$$$$", "compare_helper(bool, const char*, char*, char*, const char*, const char*, const char*, int)", typeof(bool), typeof(bool), success, typeof(string), msg, typeof(Pointer<sbyte>), val1, typeof(Pointer<sbyte>), val2, typeof(string), expected, typeof(string), actual, typeof(string), file, typeof(int), line);
        }
        public static void QSleep(int ms) {
            staticInterceptor.Invoke("qSleep$", "qSleep(int)", typeof(void), typeof(int), ms);
        }
        public static void AddColumnInternal(int id, string name) {
            staticInterceptor.Invoke("addColumnInternal$$", "addColumnInternal(int, const char*)", typeof(void), typeof(int), id, typeof(string), name);
        }
        public static QTestData NewRow(string dataTag) {
            return (QTestData) staticInterceptor.Invoke("newRow$", "newRow(const char*)", typeof(QTestData), typeof(string), dataTag);
        }
        public static bool Compare_string_helper(string t1, string t2, string actual, string expected, string file, int line) {
            return (bool) staticInterceptor.Invoke("compare_string_helper$$$$$$", "compare_string_helper(const char*, const char*, const char*, const char*, const char*, int)", typeof(bool), typeof(string), t1, typeof(string), t2, typeof(string), actual, typeof(string), expected, typeof(string), file, typeof(int), line);
        }
        public static void MousePress(QWidget widget, Qt.MouseButton button, uint stateKey, QPoint pos, int delay) {
            staticInterceptor.Invoke("mousePress#$$#$", "mousePress(QWidget*, Qt::MouseButton, Qt::KeyboardModifiers, QPoint, int)", typeof(void), typeof(QWidget), widget, typeof(Qt.MouseButton), button, typeof(uint), stateKey, typeof(QPoint), pos, typeof(int), delay);
        }
        public static void MousePress(QWidget widget, Qt.MouseButton button, uint stateKey, QPoint pos) {
            staticInterceptor.Invoke("mousePress#$$#", "mousePress(QWidget*, Qt::MouseButton, Qt::KeyboardModifiers, QPoint)", typeof(void), typeof(QWidget), widget, typeof(Qt.MouseButton), button, typeof(uint), stateKey, typeof(QPoint), pos);
        }
        public static void MousePress(QWidget widget, Qt.MouseButton button, uint stateKey) {
            staticInterceptor.Invoke("mousePress#$$", "mousePress(QWidget*, Qt::MouseButton, Qt::KeyboardModifiers)", typeof(void), typeof(QWidget), widget, typeof(Qt.MouseButton), button, typeof(uint), stateKey);
        }
        public static void MousePress(QWidget widget, Qt.MouseButton button) {
            staticInterceptor.Invoke("mousePress#$", "mousePress(QWidget*, Qt::MouseButton)", typeof(void), typeof(QWidget), widget, typeof(Qt.MouseButton), button);
        }
        public static void MouseRelease(QWidget widget, Qt.MouseButton button, uint stateKey, QPoint pos, int delay) {
            staticInterceptor.Invoke("mouseRelease#$$#$", "mouseRelease(QWidget*, Qt::MouseButton, Qt::KeyboardModifiers, QPoint, int)", typeof(void), typeof(QWidget), widget, typeof(Qt.MouseButton), button, typeof(uint), stateKey, typeof(QPoint), pos, typeof(int), delay);
        }
        public static void MouseRelease(QWidget widget, Qt.MouseButton button, uint stateKey, QPoint pos) {
            staticInterceptor.Invoke("mouseRelease#$$#", "mouseRelease(QWidget*, Qt::MouseButton, Qt::KeyboardModifiers, QPoint)", typeof(void), typeof(QWidget), widget, typeof(Qt.MouseButton), button, typeof(uint), stateKey, typeof(QPoint), pos);
        }
        public static void MouseRelease(QWidget widget, Qt.MouseButton button, uint stateKey) {
            staticInterceptor.Invoke("mouseRelease#$$", "mouseRelease(QWidget*, Qt::MouseButton, Qt::KeyboardModifiers)", typeof(void), typeof(QWidget), widget, typeof(Qt.MouseButton), button, typeof(uint), stateKey);
        }
        public static void MouseRelease(QWidget widget, Qt.MouseButton button) {
            staticInterceptor.Invoke("mouseRelease#$", "mouseRelease(QWidget*, Qt::MouseButton)", typeof(void), typeof(QWidget), widget, typeof(Qt.MouseButton), button);
        }
        public static void MouseClick(QWidget widget, Qt.MouseButton button, uint stateKey, QPoint pos, int delay) {
            staticInterceptor.Invoke("mouseClick#$$#$", "mouseClick(QWidget*, Qt::MouseButton, Qt::KeyboardModifiers, QPoint, int)", typeof(void), typeof(QWidget), widget, typeof(Qt.MouseButton), button, typeof(uint), stateKey, typeof(QPoint), pos, typeof(int), delay);
        }
        public static void MouseClick(QWidget widget, Qt.MouseButton button, uint stateKey, QPoint pos) {
            staticInterceptor.Invoke("mouseClick#$$#", "mouseClick(QWidget*, Qt::MouseButton, Qt::KeyboardModifiers, QPoint)", typeof(void), typeof(QWidget), widget, typeof(Qt.MouseButton), button, typeof(uint), stateKey, typeof(QPoint), pos);
        }
        public static void MouseClick(QWidget widget, Qt.MouseButton button, uint stateKey) {
            staticInterceptor.Invoke("mouseClick#$$", "mouseClick(QWidget*, Qt::MouseButton, Qt::KeyboardModifiers)", typeof(void), typeof(QWidget), widget, typeof(Qt.MouseButton), button, typeof(uint), stateKey);
        }
        public static void MouseClick(QWidget widget, Qt.MouseButton button) {
            staticInterceptor.Invoke("mouseClick#$", "mouseClick(QWidget*, Qt::MouseButton)", typeof(void), typeof(QWidget), widget, typeof(Qt.MouseButton), button);
        }
        public static void MouseDClick(QWidget widget, Qt.MouseButton button, uint stateKey, QPoint pos, int delay) {
            staticInterceptor.Invoke("mouseDClick#$$#$", "mouseDClick(QWidget*, Qt::MouseButton, Qt::KeyboardModifiers, QPoint, int)", typeof(void), typeof(QWidget), widget, typeof(Qt.MouseButton), button, typeof(uint), stateKey, typeof(QPoint), pos, typeof(int), delay);
        }
        public static void MouseDClick(QWidget widget, Qt.MouseButton button, uint stateKey, QPoint pos) {
            staticInterceptor.Invoke("mouseDClick#$$#", "mouseDClick(QWidget*, Qt::MouseButton, Qt::KeyboardModifiers, QPoint)", typeof(void), typeof(QWidget), widget, typeof(Qt.MouseButton), button, typeof(uint), stateKey, typeof(QPoint), pos);
        }
        public static void MouseDClick(QWidget widget, Qt.MouseButton button, uint stateKey) {
            staticInterceptor.Invoke("mouseDClick#$$", "mouseDClick(QWidget*, Qt::MouseButton, Qt::KeyboardModifiers)", typeof(void), typeof(QWidget), widget, typeof(Qt.MouseButton), button, typeof(uint), stateKey);
        }
        public static void MouseDClick(QWidget widget, Qt.MouseButton button) {
            staticInterceptor.Invoke("mouseDClick#$", "mouseDClick(QWidget*, Qt::MouseButton)", typeof(void), typeof(QWidget), widget, typeof(Qt.MouseButton), button);
        }
        public static void MouseMove(QWidget widget, QPoint pos, int delay) {
            staticInterceptor.Invoke("mouseMove##$", "mouseMove(QWidget*, QPoint, int)", typeof(void), typeof(QWidget), widget, typeof(QPoint), pos, typeof(int), delay);
        }
        public static void MouseMove(QWidget widget, QPoint pos) {
            staticInterceptor.Invoke("mouseMove##", "mouseMove(QWidget*, QPoint)", typeof(void), typeof(QWidget), widget, typeof(QPoint), pos);
        }
        public static void MouseMove(QWidget widget) {
            staticInterceptor.Invoke("mouseMove#", "mouseMove(QWidget*)", typeof(void), typeof(QWidget), widget);
        }
        public static void QWait(int ms) {
            staticInterceptor.Invoke("qWait$", "qWait(int)", typeof(void), typeof(int), ms);
        }
        public static void MouseEvent(QTest.MouseAction action, QWidget widget, Qt.MouseButton button, uint stateKey, QPoint pos, int delay) {
            staticInterceptor.Invoke("mouseEvent$#$$#$", "mouseEvent(QTest::MouseAction, QWidget*, Qt::MouseButton, Qt::KeyboardModifiers, QPoint, int)", typeof(void), typeof(QTest.MouseAction), action, typeof(QWidget), widget, typeof(Qt.MouseButton), button, typeof(uint), stateKey, typeof(QPoint), pos, typeof(int), delay);
        }
        public static void MouseEvent(QTest.MouseAction action, QWidget widget, Qt.MouseButton button, uint stateKey, QPoint pos) {
            staticInterceptor.Invoke("mouseEvent$#$$#", "mouseEvent(QTest::MouseAction, QWidget*, Qt::MouseButton, Qt::KeyboardModifiers, QPoint)", typeof(void), typeof(QTest.MouseAction), action, typeof(QWidget), widget, typeof(Qt.MouseButton), button, typeof(uint), stateKey, typeof(QPoint), pos);
        }
        public static void SimulateEvent(QWidget widget, bool press, int code, uint modifier, string text, bool repeat, int delay) {
            staticInterceptor.Invoke("simulateEvent#$$$$$$", "simulateEvent(QWidget*, bool, int, Qt::KeyboardModifiers, QString, bool, int)", typeof(void), typeof(QWidget), widget, typeof(bool), press, typeof(int), code, typeof(uint), modifier, typeof(string), text, typeof(bool), repeat, typeof(int), delay);
        }
        public static void SimulateEvent(QWidget widget, bool press, int code, uint modifier, string text, bool repeat) {
            staticInterceptor.Invoke("simulateEvent#$$$$$", "simulateEvent(QWidget*, bool, int, Qt::KeyboardModifiers, QString, bool)", typeof(void), typeof(QWidget), widget, typeof(bool), press, typeof(int), code, typeof(uint), modifier, typeof(string), text, typeof(bool), repeat);
        }
        public static void SendKeyEvent(QTest.KeyAction action, QWidget widget, Qt.Key code, string text, uint modifier, int delay) {
            staticInterceptor.Invoke("sendKeyEvent$#$$$$", "sendKeyEvent(QTest::KeyAction, QWidget*, Qt::Key, QString, Qt::KeyboardModifiers, int)", typeof(void), typeof(QTest.KeyAction), action, typeof(QWidget), widget, typeof(Qt.Key), code, typeof(string), text, typeof(uint), modifier, typeof(int), delay);
        }
        public static void SendKeyEvent(QTest.KeyAction action, QWidget widget, Qt.Key code, string text, uint modifier) {
            staticInterceptor.Invoke("sendKeyEvent$#$$$", "sendKeyEvent(QTest::KeyAction, QWidget*, Qt::Key, QString, Qt::KeyboardModifiers)", typeof(void), typeof(QTest.KeyAction), action, typeof(QWidget), widget, typeof(Qt.Key), code, typeof(string), text, typeof(uint), modifier);
        }
        public static void SendKeyEvent(QTest.KeyAction action, QWidget widget, Qt.Key code, char ascii, uint modifier, int delay) {
            staticInterceptor.Invoke("sendKeyEvent$#$$$$", "sendKeyEvent(QTest::KeyAction, QWidget*, Qt::Key, char, Qt::KeyboardModifiers, int)", typeof(void), typeof(QTest.KeyAction), action, typeof(QWidget), widget, typeof(Qt.Key), code, typeof(char), ascii, typeof(uint), modifier, typeof(int), delay);
        }
        public static void SendKeyEvent(QTest.KeyAction action, QWidget widget, Qt.Key code, char ascii, uint modifier) {
            staticInterceptor.Invoke("sendKeyEvent$#$$$", "sendKeyEvent(QTest::KeyAction, QWidget*, Qt::Key, char, Qt::KeyboardModifiers)", typeof(void), typeof(QTest.KeyAction), action, typeof(QWidget), widget, typeof(Qt.Key), code, typeof(char), ascii, typeof(uint), modifier);
        }
        public static void KeyEvent(QTest.KeyAction action, QWidget widget, char ascii, uint modifier, int delay) {
            staticInterceptor.Invoke("keyEvent$#$$$", "keyEvent(QTest::KeyAction, QWidget*, char, Qt::KeyboardModifiers, int)", typeof(void), typeof(QTest.KeyAction), action, typeof(QWidget), widget, typeof(char), ascii, typeof(uint), modifier, typeof(int), delay);
        }
        public static void KeyEvent(QTest.KeyAction action, QWidget widget, char ascii, uint modifier) {
            staticInterceptor.Invoke("keyEvent$#$$", "keyEvent(QTest::KeyAction, QWidget*, char, Qt::KeyboardModifiers)", typeof(void), typeof(QTest.KeyAction), action, typeof(QWidget), widget, typeof(char), ascii, typeof(uint), modifier);
        }
        public static void KeyEvent(QTest.KeyAction action, QWidget widget, char ascii) {
            staticInterceptor.Invoke("keyEvent$#$", "keyEvent(QTest::KeyAction, QWidget*, char)", typeof(void), typeof(QTest.KeyAction), action, typeof(QWidget), widget, typeof(char), ascii);
        }
        public static void KeyEvent(QTest.KeyAction action, QWidget widget, Qt.Key key, uint modifier, int delay) {
            staticInterceptor.Invoke("keyEvent$#$$$", "keyEvent(QTest::KeyAction, QWidget*, Qt::Key, Qt::KeyboardModifiers, int)", typeof(void), typeof(QTest.KeyAction), action, typeof(QWidget), widget, typeof(Qt.Key), key, typeof(uint), modifier, typeof(int), delay);
        }
        public static void KeyEvent(QTest.KeyAction action, QWidget widget, Qt.Key key, uint modifier) {
            staticInterceptor.Invoke("keyEvent$#$$", "keyEvent(QTest::KeyAction, QWidget*, Qt::Key, Qt::KeyboardModifiers)", typeof(void), typeof(QTest.KeyAction), action, typeof(QWidget), widget, typeof(Qt.Key), key, typeof(uint), modifier);
        }
        public static void KeyEvent(QTest.KeyAction action, QWidget widget, Qt.Key key) {
            staticInterceptor.Invoke("keyEvent$#$", "keyEvent(QTest::KeyAction, QWidget*, Qt::Key)", typeof(void), typeof(QTest.KeyAction), action, typeof(QWidget), widget, typeof(Qt.Key), key);
        }
        public static void KeyClicks(QWidget widget, string sequence, uint modifier, int delay) {
            staticInterceptor.Invoke("keyClicks#$$$", "keyClicks(QWidget*, const QString&, Qt::KeyboardModifiers, int)", typeof(void), typeof(QWidget), widget, typeof(string), sequence, typeof(uint), modifier, typeof(int), delay);
        }
        public static void KeyClicks(QWidget widget, string sequence, uint modifier) {
            staticInterceptor.Invoke("keyClicks#$$", "keyClicks(QWidget*, const QString&, Qt::KeyboardModifiers)", typeof(void), typeof(QWidget), widget, typeof(string), sequence, typeof(uint), modifier);
        }
        public static void KeyClicks(QWidget widget, string sequence) {
            staticInterceptor.Invoke("keyClicks#$", "keyClicks(QWidget*, const QString&)", typeof(void), typeof(QWidget), widget, typeof(string), sequence);
        }
        public static void KeyPress(QWidget widget, char key, uint modifier, int delay) {
            staticInterceptor.Invoke("keyPress#$$$", "keyPress(QWidget*, char, Qt::KeyboardModifiers, int)", typeof(void), typeof(QWidget), widget, typeof(char), key, typeof(uint), modifier, typeof(int), delay);
        }
        public static void KeyPress(QWidget widget, char key, uint modifier) {
            staticInterceptor.Invoke("keyPress#$$", "keyPress(QWidget*, char, Qt::KeyboardModifiers)", typeof(void), typeof(QWidget), widget, typeof(char), key, typeof(uint), modifier);
        }
        public static void KeyPress(QWidget widget, char key) {
            staticInterceptor.Invoke("keyPress#$", "keyPress(QWidget*, char)", typeof(void), typeof(QWidget), widget, typeof(char), key);
        }
        public static void KeyRelease(QWidget widget, char key, uint modifier, int delay) {
            staticInterceptor.Invoke("keyRelease#$$$", "keyRelease(QWidget*, char, Qt::KeyboardModifiers, int)", typeof(void), typeof(QWidget), widget, typeof(char), key, typeof(uint), modifier, typeof(int), delay);
        }
        public static void KeyRelease(QWidget widget, char key, uint modifier) {
            staticInterceptor.Invoke("keyRelease#$$", "keyRelease(QWidget*, char, Qt::KeyboardModifiers)", typeof(void), typeof(QWidget), widget, typeof(char), key, typeof(uint), modifier);
        }
        public static void KeyRelease(QWidget widget, char key) {
            staticInterceptor.Invoke("keyRelease#$", "keyRelease(QWidget*, char)", typeof(void), typeof(QWidget), widget, typeof(char), key);
        }
        public static void KeyClick(QWidget widget, char key, uint modifier, int delay) {
            staticInterceptor.Invoke("keyClick#$$$", "keyClick(QWidget*, char, Qt::KeyboardModifiers, int)", typeof(void), typeof(QWidget), widget, typeof(char), key, typeof(uint), modifier, typeof(int), delay);
        }
        public static void KeyClick(QWidget widget, char key, uint modifier) {
            staticInterceptor.Invoke("keyClick#$$", "keyClick(QWidget*, char, Qt::KeyboardModifiers)", typeof(void), typeof(QWidget), widget, typeof(char), key, typeof(uint), modifier);
        }
        public static void KeyClick(QWidget widget, char key) {
            staticInterceptor.Invoke("keyClick#$", "keyClick(QWidget*, char)", typeof(void), typeof(QWidget), widget, typeof(char), key);
        }
        public static void KeyPress(QWidget widget, Qt.Key key, uint modifier, int delay) {
            staticInterceptor.Invoke("keyPress#$$$", "keyPress(QWidget*, Qt::Key, Qt::KeyboardModifiers, int)", typeof(void), typeof(QWidget), widget, typeof(Qt.Key), key, typeof(uint), modifier, typeof(int), delay);
        }
        public static void KeyPress(QWidget widget, Qt.Key key, uint modifier) {
            staticInterceptor.Invoke("keyPress#$$", "keyPress(QWidget*, Qt::Key, Qt::KeyboardModifiers)", typeof(void), typeof(QWidget), widget, typeof(Qt.Key), key, typeof(uint), modifier);
        }
        public static void KeyPress(QWidget widget, Qt.Key key) {
            staticInterceptor.Invoke("keyPress#$", "keyPress(QWidget*, Qt::Key)", typeof(void), typeof(QWidget), widget, typeof(Qt.Key), key);
        }
        public static void KeyRelease(QWidget widget, Qt.Key key, uint modifier, int delay) {
            staticInterceptor.Invoke("keyRelease#$$$", "keyRelease(QWidget*, Qt::Key, Qt::KeyboardModifiers, int)", typeof(void), typeof(QWidget), widget, typeof(Qt.Key), key, typeof(uint), modifier, typeof(int), delay);
        }
        public static void KeyRelease(QWidget widget, Qt.Key key, uint modifier) {
            staticInterceptor.Invoke("keyRelease#$$", "keyRelease(QWidget*, Qt::Key, Qt::KeyboardModifiers)", typeof(void), typeof(QWidget), widget, typeof(Qt.Key), key, typeof(uint), modifier);
        }
        public static void KeyRelease(QWidget widget, Qt.Key key) {
            staticInterceptor.Invoke("keyRelease#$", "keyRelease(QWidget*, Qt::Key)", typeof(void), typeof(QWidget), widget, typeof(Qt.Key), key);
        }
        public static void KeyClick(QWidget widget, Qt.Key key, uint modifier, int delay) {
            staticInterceptor.Invoke("keyClick#$$$", "keyClick(QWidget*, Qt::Key, Qt::KeyboardModifiers, int)", typeof(void), typeof(QWidget), widget, typeof(Qt.Key), key, typeof(uint), modifier, typeof(int), delay);
        }
        public static void KeyClick(QWidget widget, Qt.Key key, uint modifier) {
            staticInterceptor.Invoke("keyClick#$$", "keyClick(QWidget*, Qt::Key, Qt::KeyboardModifiers)", typeof(void), typeof(QWidget), widget, typeof(Qt.Key), key, typeof(uint), modifier);
        }
        public static void KeyClick(QWidget widget, Qt.Key key) {
            staticInterceptor.Invoke("keyClick#$", "keyClick(QWidget*, Qt::Key)", typeof(void), typeof(QWidget), widget, typeof(Qt.Key), key);
        }
    }
}