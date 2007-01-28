namespace Qyoto {
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Runtime.Remoting.Proxies;
	using System.Runtime.InteropServices;

	public class SmokeMarshallers : object {
		
#region C++ functions
		/** Marshalling functions begin **/
		[DllImport("libqyoto", CharSet=CharSet.Ansi)]
		public static extern IntPtr StringArrayToCharStarStar(int length, string[] strArray);
		
		[DllImport("libqyoto", CharSet=CharSet.Ansi)]
		public static extern IntPtr StringToQString(string str);

		[DllImport("libqyoto", CharSet=CharSet.Ansi)]
		public static extern string StringFromQString(IntPtr ptr);
		
		[DllImport("libqyoto", CharSet=CharSet.Ansi)]
		public static extern IntPtr StringArrayToQStringList(int length, string[] strArray);
		/** Marshalling functions end **/
		
		/** Other functions **/
		[DllImport("libqyoto", CharSet=CharSet.Ansi)]
		public static extern IntPtr ConstructPointerList();
		
		[DllImport("libqyoto", CharSet=CharSet.Ansi)]
		public static extern void AddObjectToPointerList(IntPtr ptr, IntPtr obj);
		
		[DllImport("libqyoto", CharSet=CharSet.Ansi)]
		public static extern IntPtr ConstructQListInt();
		
		[DllImport("libqyoto", CharSet=CharSet.Ansi)]
		public static extern void AddIntToQList(IntPtr ptr, int i);
		
		
		[DllImport("libqyoto", CharSet=CharSet.Ansi)]
		public static extern IntPtr ConstructQMap(int type);
		
		[DllImport("libqyoto", CharSet=CharSet.Ansi)]
		public static extern void AddIntQVariantToQMap(IntPtr ptr, int i, IntPtr qv);
		
		[DllImport("libqyoto", CharSet=CharSet.Ansi)]
		public static extern void AddQStringQStringToQMap(IntPtr ptr, string str1, string str2);
		
		[DllImport("libqyoto", CharSet=CharSet.Ansi)]
		public static extern void AddQStringQVariantToQMap(IntPtr ptr, string str, IntPtr qv);
		/** Other functions end **/
		
		
		[DllImport("libqyoto", CharSet=CharSet.Ansi)]
		public static extern void InstallFreeGCHandle(FromIntPtr callback);
		
		[DllImport("libqyoto", CharSet=CharSet.Ansi)]
		public static extern void InstallGetSmokeObject(GetIntPtr callback);
		
		[DllImport("libqyoto", CharSet=CharSet.Ansi)]
		public static extern void InstallSetSmokeObject(SetIntPtr callback);
		
		[DllImport("libqyoto", CharSet=CharSet.Ansi)]
		public static extern void InstallMapPointer(SetIntPtr callback);
		
		[DllImport("libqyoto", CharSet=CharSet.Ansi)]
		public static extern void InstallUnmapPointer(FromIntPtr callback);
		
		[DllImport("libqyoto", CharSet=CharSet.Ansi)]
		public static extern void InstallGetPointerObject(GetIntPtr callback);

		[DllImport("libqyoto", CharSet=CharSet.Ansi)]
		public static extern void InstallCreateInstance(CreateInstanceFn callback);
		
		[DllImport("libqyoto", CharSet=CharSet.Ansi)]
		public static extern void InstallInvokeCustomSlot(InvokeCustomSlotFn callback);
		
		[DllImport("libqyoto", CharSet=CharSet.Ansi)]
		public static extern bool InstallIsSmokeClass(IsSmokeClassFn callback);
		
		[DllImport("libqyoto", CharSet=CharSet.Ansi)]
		public static extern void InstallIntPtrToCharStarStar(GetIntPtr callback);
		
		[DllImport("libqyoto", CharSet=CharSet.Ansi)]
		public static extern void InstallIntPtrToCharStar(GetStringFromIntPtr callback);

		[DllImport("libqyoto", CharSet=CharSet.Ansi)]
		public static extern void InstallIntPtrFromCharStar(GetIntPtrFromString callback);
		
		[DllImport("libqyoto", CharSet=CharSet.Ansi)]
		public static extern void InstallIntPtrToQString(GetIntPtr callback);

		[DllImport("libqyoto", CharSet=CharSet.Ansi)]
		public static extern void InstallIntPtrFromQString(GetIntPtr callback);
		
		[DllImport("libqyoto", CharSet=CharSet.Ansi)]
		public static extern void InstallOverridenMethod(OverridenMethodFn callback);

		[DllImport("libqyoto", CharSet=CharSet.Ansi)]
		public static extern void InstallInvokeMethod(InvokeMethodFn callback);
		
		[DllImport("libqyoto", CharSet=CharSet.Ansi)]
		public static extern IntPtr InstallConstructList(CreateInstanceFn callback);

		[DllImport("libqyoto", CharSet=CharSet.Ansi)]
		public static extern IntPtr InstallStringListToQStringList(GetIntPtr callback);

		[DllImport("libqyoto", CharSet=CharSet.Ansi)]
		public static extern IntPtr InstallListToPointerList(GetIntPtr callback);

		[DllImport("libqyoto", CharSet=CharSet.Ansi)]
		public static extern IntPtr InstallListIntToQListInt(GetIntPtr callback);

		[DllImport("libqyoto", CharSet=CharSet.Ansi)]
		public static extern void InstallAddIntPtrToList(SetIntPtr callback);

		[DllImport("libqyoto", CharSet=CharSet.Ansi)]
		public static extern void InstallAddIntToListInt(AddInt callback);

		[DllImport("libqyoto", CharSet=CharSet.Ansi)]
		public static extern IntPtr InstallConstructDictionary(ConstructDict callback);

		[DllImport("libqyoto", CharSet=CharSet.Ansi)]
		public static extern void InstallAddObjectObjectToDictionary(InvokeMethodFn callback);

		[DllImport("libqyoto", CharSet=CharSet.Ansi)]
		public static extern void InstallAddIntObjectToDictionary(AddIntObject callback);

		[DllImport("libqyoto", CharSet=CharSet.Ansi)]
		public static extern void InstallDictionaryToQMap(DictToMap callback);
#endregion
		
#region delegates
		public delegate IntPtr NoArgs();
		public delegate IntPtr GetIntPtr(IntPtr instance);
		public delegate void SetIntPtr(IntPtr instance, IntPtr ptr);
		public delegate void FromIntPtr(IntPtr ptr);
		public delegate IntPtr CreateInstanceFn(string className);
		public delegate void InvokeCustomSlotFn(IntPtr obj, string slot, IntPtr stack, IntPtr ret);
		public delegate bool IsSmokeClassFn(IntPtr obj);
		public delegate IntPtr GetIntPtrFromString(string str);
		public delegate string GetStringFromIntPtr(IntPtr ptr);
		public delegate IntPtr OverridenMethodFn(IntPtr instance, string method);
		public delegate void InvokeMethodFn(IntPtr instance, IntPtr method, IntPtr args);
		public delegate void AddInt(IntPtr obj, int i);
		public delegate void AddIntObject(IntPtr hash, int key, IntPtr val);
		public delegate IntPtr DictToMap(IntPtr ptr, int type);
		public delegate IntPtr ConstructDict(string type1, string type2);
#endregion
		
#region marshallung functions
		public static void FreeGCHandle(IntPtr handle) {
			((GCHandle) handle).Free();
		}
		
		public static IntPtr GetSmokeObject(object instance) {
			if (instance == null) {
				return (IntPtr) 0;
			}
			FieldInfo fieldInfo = instance.GetType().GetField(	"_smokeObject", 
															BindingFlags.NonPublic 
															| BindingFlags.GetField
															| BindingFlags.Instance );
			return (IntPtr) fieldInfo.GetValue(instance);
		}
		
		public static IntPtr GetSmokeObject(IntPtr instancePtr) {
			if (((int) instancePtr) == 0)
				return (IntPtr) 0;
			
			Object instance = ((GCHandle) instancePtr).Target;
			return GetSmokeObject(instance);
		}
		
		public static void SetSmokeObject(object instance, IntPtr smokeObjectPtr) {
			FieldInfo fieldInfo = instance.GetType().GetField(	"_smokeObject", 
															BindingFlags.NonPublic 
															| BindingFlags.GetField
															| BindingFlags.Instance );
			fieldInfo.SetValue(instance, smokeObjectPtr);
			return;
		}
		
		public static void SetSmokeObject(IntPtr instancePtr, IntPtr smokeObjectPtr) {
			Object instance = ((GCHandle) instancePtr).Target;
			if (instance == null) {
				return;
			}
			SetSmokeObject(instance, smokeObjectPtr);
			return;
		}

		// The key is an IntPtr corresponding to the address of the C++ instance,
		// and the value is a WeakReference to the C# instance.
		static private Dictionary<IntPtr, WeakReference> pointerMap = new Dictionary<IntPtr, WeakReference>();

		public static void MapPointer(IntPtr ptr, IntPtr instancePtr) {
			Object instance = ((GCHandle) instancePtr).Target;
			WeakReference weakRef = new WeakReference(instance);
			pointerMap[ptr] = weakRef;
		}
		
		public static void UnmapPointer(IntPtr ptr) {
			pointerMap.Remove(ptr);
		}
		
		public static IntPtr GetPointerObject(IntPtr ptr) {
//			Console.WriteLine("ENTER GetPointerObject() ptr: {0}", ptr);
			WeakReference weakRef;
			if (!pointerMap.TryGetValue(ptr, out weakRef)) {
//				Console.WriteLine("GetPointerObject() pointerMap[ptr] == null");
				return (IntPtr) 0;
			}

			if (weakRef == null) {
//				Console.WriteLine("GetPointerObject() weakRef zero");
				return (IntPtr) 0;
			} else if (weakRef.IsAlive) {
//				Console.WriteLine("GetPointerObject() weakRef.IsAlive");
				GCHandle instanceHandle = GCHandle.Alloc(weakRef.Target);
				return (IntPtr) instanceHandle;
			} else {
//				Console.WriteLine("GetPointerObject() weakRef dead");
				return (IntPtr) 0;
			}
		}

		// CreateInstance() creates a wrapper instance around a C++ instance which
		// has been created in C++ code, and not via a Qyoto C# constructor call.
		// It takes the class name string and obtains its Type. Then it finds the
		// dummy constructor which takes a Type as an arg, like this for example:
		//
 		//		protected QWidget(Type dummy) : base((Type) null) {}
		//
		// The constructor is run to create the wrapper instance. Then the method 
		// 'CreateProxy()' to create the transparent proxy to forward the method
		// calls to SmokeInvocation.Invoke() is called.
		public static IntPtr CreateInstance(string className) {
			Type klass = Type.GetType(className);
#if DEBUG
			Console.WriteLine("ENTER CreateInstance className => {0}, {1}", className, klass);
#endif

			Type[] constructorParamTypes = new Type[1];
			constructorParamTypes[0] = typeof(Type);
			ConstructorInfo constructorInfo = klass.GetConstructor(BindingFlags.NonPublic 
					| BindingFlags.Instance, null, new Type[ ] { typeof( Type ) } , null);
			if (constructorInfo == null) {
				Console.WriteLine("CreateInstance(\"{0}\") constructor method missing {1}", className, constructorParamTypes[0]);
				return (IntPtr) 0;
			}
			object result = constructorInfo.Invoke(new object [] { constructorParamTypes[0] });
#if DEBUG
			Console.WriteLine("CreateInstance(\"{0}\") constructed {1}", className, result);
#endif
			Type[] paramTypes = new Type[0];
			MethodInfo proxyCreator = klass.GetMethod("CreateProxy", BindingFlags.NonPublic 
																	| BindingFlags.Instance
																	| BindingFlags.DeclaredOnly);
			if (proxyCreator == null) {
				Console.WriteLine("CreateInstance() proxyCreator method missing");
				return (IntPtr) 0;
			}
			proxyCreator.Invoke(result, null);
			return (IntPtr) GCHandle.Alloc(result);
		}

		public static IntPtr IntPtrToCharStarStar(IntPtr ptr) {
			string[] temp = (string[]) ((GCHandle) ptr).Target;
			return StringArrayToCharStarStar(temp.Length, temp);
		}

		public static string IntPtrToString(IntPtr ptr) {
			string temp = (string) ((GCHandle) ptr).Target;
			return temp;
		}

		public static IntPtr IntPtrFromString(string str) {
			return (IntPtr) GCHandle.Alloc(str);
		}

		public static IntPtr IntPtrToQString(IntPtr ptr) {
			string temp = (string) ((GCHandle) ptr).Target;
			return StringToQString(temp);
		}

		public static IntPtr IntPtrFromQString(IntPtr ptr) {
			return (IntPtr) GCHandle.Alloc(StringFromQString(ptr));
		}

		public static IntPtr StringListToQStringList(IntPtr ptr) {
			List<string> sl = (List<string>) ((GCHandle) ptr).Target;
			string[] s = (string[]) sl.ToArray();
			return StringArrayToQStringList(s.Length, s);
		}

		public static IntPtr ListIntToQListInt(IntPtr ptr) {
			List<int> il = (List<int>) ((GCHandle) ptr).Target;
			IntPtr QList = ConstructQListInt();
			foreach (int i in il) {
				AddIntToQList(QList, i);
			}
			return QList;
		}

		public static IntPtr ListToPointerList(IntPtr ptr) {
			object l = ((GCHandle) ptr).Target;
			// convert the list to an array via reflection. this is probably the easiest way
			object[] oa = (object[]) l.GetType().GetMethod("ToArray").Invoke(l, null);
			
			IntPtr list = ConstructPointerList();
			foreach (object o in oa) {
				AddObjectToPointerList(list, (IntPtr) GCHandle.Alloc(o));
			}
			return list;
		}

		public static IntPtr ConstructList(string type) {
			Type basetype = typeof(List<>);
			Type[] generic = { Type.GetType(type) };
			Type merged = basetype.MakeGenericType(generic);
			
			object o = Activator.CreateInstance(merged);
			
			return (IntPtr) GCHandle.Alloc(o);
		}

		public static void AddIntPtrToList(IntPtr obj, IntPtr ptr) {
			object list = ((GCHandle) obj).Target;
			object o = ((GCHandle) ptr).Target;
			object[] args = { o };
			list.GetType().GetMethod("Add").Invoke(list, args);
		}

		public static void AddIntToListInt(IntPtr obj, int i) {
			List<int> il = (List<int>) ((GCHandle) obj).Target;
			il.Add(i);
		}

		public static IntPtr ConstructDictionary(string type1, string type2) {
			Type basetype = typeof(Dictionary<,>);
			Type[] generic = { Type.GetType(type1), Type.GetType(type2) };
			Type merged = basetype.MakeGenericType(generic);
			
			object o = Activator.CreateInstance(merged);
			
			return (IntPtr) GCHandle.Alloc(o);
		}

		public static void AddObjectObjectToDictionary(IntPtr dic, IntPtr key, IntPtr val) {
			object d = ((GCHandle) dic).Target;
			object k = ((GCHandle) key).Target;
			object v = ((GCHandle) val).Target;
			object[] args = { k, v };
			d.GetType().GetMethod("Add").Invoke(d, args);
		}

		public static void AddIntObjectToDictionary(IntPtr dict, int key, IntPtr val) {
			object d = ((GCHandle) dict).Target;
			object v = ((GCHandle) val).Target;
			object[] args = { key, v };
			d.GetType().GetMethod("Add").Invoke(d, args);
		}

		public static IntPtr DictionaryToQMap(IntPtr dict, int type) {
			object d = ((GCHandle) dict).Target;
			IntPtr map = ConstructQMap(type);
			
			if (type == 0) {
				Dictionary<int, QVariant> d1 = (Dictionary<int, QVariant>) d;
				foreach (KeyValuePair<int, QVariant> kvp in d1) {
					AddIntQVariantToQMap(map, kvp.Key, (IntPtr) GCHandle.Alloc(kvp.Value));
				}
			} else if (type == 1) {
				Dictionary<string, string> d1 = (Dictionary<string, string>) d;
				foreach (KeyValuePair<string, string> kvp in d1) {
					AddQStringQStringToQMap(map, kvp.Key, kvp.Value);
				}
			} else if (type == 2) {
				Dictionary<string, QVariant> d1 = (Dictionary<string, QVariant>) d;
				foreach (KeyValuePair<string, QVariant> kvp in d1) {
					AddQStringQVariantToQMap(map, kvp.Key, (IntPtr) GCHandle.Alloc(kvp.Value));
				}
			}
			return map;
		}
#endregion
		
#region Setup
		static private FromIntPtr freeGCHandle = new FromIntPtr(FreeGCHandle);

		static private GetIntPtr getSmokeObject = new GetIntPtr(GetSmokeObject);
		static private SetIntPtr setSmokeObject = new SetIntPtr(SetSmokeObject);
		
		static private SetIntPtr mapPointer = new SetIntPtr(MapPointer);
		static private FromIntPtr unmapPointer = new FromIntPtr(UnmapPointer);
		static private GetIntPtr getPointerObject = new GetIntPtr(GetPointerObject);
		
		static private GetIntPtr intPtrToCharStarStar = new GetIntPtr(IntPtrToCharStarStar);
		static private GetStringFromIntPtr intPtrToString = new GetStringFromIntPtr(IntPtrToString);
		static private GetIntPtrFromString intPtrFromString = new GetIntPtrFromString(IntPtrFromString);
		static private GetIntPtr intPtrToQString = new GetIntPtr(IntPtrToQString);
		static private GetIntPtr intPtrFromQString = new GetIntPtr(IntPtrFromQString);
		
		static private GetIntPtr stringListToQStringList = new GetIntPtr(StringListToQStringList);
		static private GetIntPtr listToPointerList = new GetIntPtr(ListToPointerList);
		static private GetIntPtr listIntToQListInt = new GetIntPtr(ListIntToQListInt);
		
		static private DictToMap dictionaryToQMap = new DictToMap(DictionaryToQMap);
		
		static private CreateInstanceFn constructList = new CreateInstanceFn(ConstructList);
		static private SetIntPtr addIntPtrToList = new SetIntPtr(AddIntPtrToList);
		static private AddInt addIntToListInt = new AddInt(AddIntToListInt);
		
		static private ConstructDict constructDictionary = new ConstructDict(ConstructDictionary);
		static private InvokeMethodFn addObjectObjectToDictionary = new InvokeMethodFn(AddObjectObjectToDictionary);
		static private AddIntObject addIntObjectToDictionary = new AddIntObject(AddIntObjectToDictionary);
		
		static private OverridenMethodFn overridenMethod = new OverridenMethodFn(SmokeInvocation.OverridenMethod);
		static private InvokeMethodFn invokeMethod = new InvokeMethodFn(SmokeInvocation.InvokeMethod);

		static private CreateInstanceFn createInstance = new CreateInstanceFn(CreateInstance);
		static private InvokeCustomSlotFn invokeCustomSlot = new InvokeCustomSlotFn(SmokeInvocation.InvokeCustomSlot);
		static private IsSmokeClassFn isSmokeClass = new IsSmokeClassFn(Qyoto.IsSmokeClass);
		
		public static void SetUp() {
			InstallFreeGCHandle(freeGCHandle);

			InstallGetSmokeObject(getSmokeObject);
			InstallSetSmokeObject(setSmokeObject);
			
			InstallMapPointer(mapPointer);
			InstallUnmapPointer(unmapPointer);
			InstallGetPointerObject(getPointerObject);

			InstallIntPtrToCharStarStar(intPtrToCharStarStar);
			InstallIntPtrToCharStar(intPtrToString);
			InstallIntPtrFromCharStar(intPtrFromString);
			InstallIntPtrToQString(intPtrToQString);
			InstallIntPtrFromQString(intPtrFromQString);
			InstallConstructList(constructList);
			InstallStringListToQStringList(stringListToQStringList);
			InstallListToPointerList(listToPointerList);
			InstallListIntToQListInt(listIntToQListInt);
			InstallAddIntPtrToList(addIntPtrToList);
			InstallAddIntToListInt(addIntToListInt);

			InstallConstructDictionary(constructDictionary);
			InstallAddObjectObjectToDictionary(addObjectObjectToDictionary);
			InstallAddIntObjectToDictionary(addIntObjectToDictionary);
			
			InstallDictionaryToQMap(dictionaryToQMap);

			InstallOverridenMethod(overridenMethod);
			InstallInvokeMethod(invokeMethod);

			InstallCreateInstance(createInstance);
			InstallInvokeCustomSlot(invokeCustomSlot);
			InstallIsSmokeClass(isSmokeClass);
		}
#endregion

	}
}