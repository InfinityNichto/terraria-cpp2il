using System;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x020002EE RID: 750
	[global::Cpp2ILInjected.Token(Token = "0x20003F1")]
	public sealed class TypeDescriptor
	{
		// Token: 0x06001892 RID: 6290 RVA: 0x00007340 File Offset: 0x00005540
		[global::Cpp2ILInjected.Token(Token = "0x6001B1B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E78C54", Offset = "0x1E78C54", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		private TypeDescriptor()
		{
			throw null;
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x06001893 RID: 6291 RVA: 0x00007343 File Offset: 0x00005543
		// (set) Token: 0x06001894 RID: 6292 RVA: 0x00007346 File Offset: 0x00005546
		[Obsolete("This property has been deprecated.  Use a type description provider to supply type information for COM types instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
		[global::Cpp2ILInjected.Token(Token = "0x17000632")]
		public static IComNativeDescriptorHandler ComNativeDescriptorHandler
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B1C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E78C5C", Offset = "0x1E78C5C", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "get_ComObjectType", ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "NodeFor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(TypeDescriptor.TypeDescriptionNode))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001B1D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E78DBC", Offset = "0x1E78DBC", Length = "0xD4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "get_ComObjectType", ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "NodeFor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(TypeDescriptor.TypeDescriptionNode))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor.ComNativeDescriptionProvider), Member = ".ctor", MemberParameters = new object[] { typeof(IComNativeDescriptorHandler) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x06001895 RID: 6293 RVA: 0x00007349 File Offset: 0x00005549
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[global::Cpp2ILInjected.Token(Token = "0x17000633")]
		public static Type ComObjectType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B1E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E78CF8", Offset = "0x1E78CF8", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "get_ComNativeDescriptorHandler", ReturnType = typeof(IComNativeDescriptorHandler))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "set_ComNativeDescriptorHandler", MemberParameters = new object[] { typeof(IComNativeDescriptorHandler) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "NodeFor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(bool)
			}, ReturnType = typeof(TypeDescriptor.TypeDescriptionNode))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x06001896 RID: 6294 RVA: 0x0000734C File Offset: 0x0000554C
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[global::Cpp2ILInjected.Token(Token = "0x17000634")]
		public static Type InterfaceType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B1F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E790F4", Offset = "0x1E790F4", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetNodeForBaseType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x06001897 RID: 6295 RVA: 0x0000734F File Offset: 0x0000554F
		[global::Cpp2ILInjected.Token(Token = "0x17000635")]
		internal static int MetadataVersion
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B20")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E79160", Offset = "0x1E79160", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1400001B RID: 27
		// (add) Token: 0x06001898 RID: 6296 RVA: 0x00007352 File Offset: 0x00005552
		// (remove) Token: 0x06001899 RID: 6297 RVA: 0x00007355 File Offset: 0x00005555
		[global::Cpp2ILInjected.Token(Token = "0x1400001B")]
		public static event RefreshEventHandler Refreshed
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001B21")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E791B8", Offset = "0x1E791B8", Length = "0xDC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001B22")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E79294", Offset = "0x1E79294", Length = "0xDC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x0600189A RID: 6298 RVA: 0x00007358 File Offset: 0x00005558
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[global::Cpp2ILInjected.Token(Token = "0x6001B23")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E79370", Offset = "0x1E79370", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetProvider", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(TypeDescriptionProvider))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor.AttributeProvider), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(TypeDescriptionProvider),
			typeof(Attribute[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "AddProvider", MemberParameters = new object[]
		{
			typeof(TypeDescriptionProvider),
			typeof(Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public static TypeDescriptionProvider AddAttributes(Type type, params Attribute[] attributes)
		{
			throw null;
		}

		// Token: 0x0600189B RID: 6299 RVA: 0x0000735B File Offset: 0x0000555B
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[global::Cpp2ILInjected.Token(Token = "0x6001B24")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E79598", Offset = "0x1E79598", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetProvider", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(TypeDescriptionProvider))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor.AttributeProvider), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(TypeDescriptionProvider),
			typeof(Attribute[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "AddProvider", MemberParameters = new object[]
		{
			typeof(TypeDescriptionProvider),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public static TypeDescriptionProvider AddAttributes(object instance, params Attribute[] attributes)
		{
			throw null;
		}

		// Token: 0x0600189C RID: 6300 RVA: 0x0000735E File Offset: 0x0000555E
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[global::Cpp2ILInjected.Token(Token = "0x6001B25")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E799BC", Offset = "0x1E799BC", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "AddEditorTable", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Hashtable)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void AddEditorTable(Type editorBaseType, Hashtable table)
		{
			throw null;
		}

		// Token: 0x0600189D RID: 6301 RVA: 0x00007361 File Offset: 0x00005561
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[global::Cpp2ILInjected.Token(Token = "0x6001B26")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E78E90", Offset = "0x1E78E90", Length = "0x264")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "AddAttributes", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Attribute[])
		}, ReturnType = typeof(TypeDescriptionProvider))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "AddProviderTransparent", MemberParameters = new object[]
		{
			typeof(TypeDescriptionProvider),
			typeof(Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "CheckDefaultProvider", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "NodeFor", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(bool)
		}, ReturnType = typeof(TypeDescriptor.TypeDescriptionNode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor.TypeDescriptionNode), Member = ".ctor", MemberParameters = new object[] { typeof(TypeDescriptionProvider) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "Refresh", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public static void AddProvider(TypeDescriptionProvider provider, Type type)
		{
			throw null;
		}

		// Token: 0x0600189E RID: 6302 RVA: 0x00007364 File Offset: 0x00005564
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[global::Cpp2ILInjected.Token(Token = "0x6001B27")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E79758", Offset = "0x1E79758", Length = "0x264")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "AddAttributes", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Attribute[])
		}, ReturnType = typeof(TypeDescriptionProvider))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "AddProviderTransparent", MemberParameters = new object[]
		{
			typeof(TypeDescriptionProvider),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "NodeFor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(TypeDescriptor.TypeDescriptionNode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor.TypeDescriptionNode), Member = ".ctor", MemberParameters = new object[] { typeof(TypeDescriptionProvider) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WeakHashtable), Member = "SetWeak", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "Refresh", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public static void AddProvider(TypeDescriptionProvider provider, object instance)
		{
			throw null;
		}

		// Token: 0x0600189F RID: 6303 RVA: 0x00007367 File Offset: 0x00005567
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[global::Cpp2ILInjected.Token(Token = "0x6001B28")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E7AE44", Offset = "0x1E7AE44", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "AddProvider", MemberParameters = new object[]
		{
			typeof(TypeDescriptionProvider),
			typeof(Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public static void AddProviderTransparent(TypeDescriptionProvider provider, Type type)
		{
			throw null;
		}

		// Token: 0x060018A0 RID: 6304 RVA: 0x0000736A File Offset: 0x0000556A
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[global::Cpp2ILInjected.Token(Token = "0x6001B29")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E7AF44", Offset = "0x1E7AF44", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "AddProvider", MemberParameters = new object[]
		{
			typeof(TypeDescriptionProvider),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static void AddProviderTransparent(TypeDescriptionProvider provider, object instance)
		{
			throw null;
		}

		// Token: 0x060018A1 RID: 6305 RVA: 0x0000736D File Offset: 0x0000556D
		[global::Cpp2ILInjected.Token(Token = "0x6001B2A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E7B010", Offset = "0x1E7B010", Length = "0x5B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "CheckDefaultProvider", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "NodeFor", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(bool)
		}, ReturnType = typeof(TypeDescriptor.TypeDescriptionNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "AddProvider", MemberParameters = new object[]
		{
			typeof(TypeDescriptionProvider),
			typeof(Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "CheckDefaultProvider", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 44)]
		private static void CheckDefaultProvider(Type type)
		{
			throw null;
		}

		// Token: 0x060018A2 RID: 6306 RVA: 0x00007370 File Offset: 0x00005570
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[global::Cpp2ILInjected.Token(Token = "0x6001B2B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E7B5C8", Offset = "0x1E7B5C8", Length = "0x70C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WeakHashtable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WeakHashtable), Member = "SetWeak", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WeakReference), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 58)]
		public static void CreateAssociation(object primary, object secondary)
		{
			throw null;
		}

		// Token: 0x060018A3 RID: 6307 RVA: 0x00007373 File Offset: 0x00005573
		[global::Cpp2ILInjected.Token(Token = "0x6001B2C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E7BCD4", Offset = "0x1E7BCD4", Length = "0x450")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(AttributeCollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AttributeCollection), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityUtils), Member = "SecureCreateInstance", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(object[]),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
		public static IDesigner CreateDesigner(IComponent component, Type designerBaseType)
		{
			throw null;
		}

		// Token: 0x060018A4 RID: 6308 RVA: 0x00007376 File Offset: 0x00005576
		[global::Cpp2ILInjected.Token(Token = "0x6001B2D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E7C124", Offset = "0x1E7C124", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectEventDescriptor), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(string),
			typeof(Type),
			typeof(Attribute[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static EventDescriptor CreateEvent(Type componentType, string name, Type type, params Attribute[] attributes)
		{
			throw null;
		}

		// Token: 0x060018A5 RID: 6309 RVA: 0x00007379 File Offset: 0x00005579
		[global::Cpp2ILInjected.Token(Token = "0x6001B2E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E7C1A8", Offset = "0x1E7C1A8", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectEventDescriptor), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(EventDescriptor),
			typeof(Attribute[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static EventDescriptor CreateEvent(Type componentType, EventDescriptor oldEventDescriptor, params Attribute[] attributes)
		{
			throw null;
		}

		// Token: 0x060018A6 RID: 6310 RVA: 0x0000737C File Offset: 0x0000557C
		[global::Cpp2ILInjected.Token(Token = "0x6001B2F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E7C21C", Offset = "0x1E7C21C", Length = "0x2B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PropertyDescriptor), Member = "CreateInstance", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "NodeFor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(TypeDescriptor.TypeDescriptionNode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public static object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args)
		{
			throw null;
		}

		// Token: 0x060018A7 RID: 6311 RVA: 0x0000737F File Offset: 0x0000557F
		[global::Cpp2ILInjected.Token(Token = "0x6001B30")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E7C4D0", Offset = "0x1E7C4D0", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectPropertyDescriptor), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(string),
			typeof(Type),
			typeof(Attribute[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static PropertyDescriptor CreateProperty(Type componentType, string name, Type type, params Attribute[] attributes)
		{
			throw null;
		}

		// Token: 0x060018A8 RID: 6312 RVA: 0x00007382 File Offset: 0x00005582
		[global::Cpp2ILInjected.Token(Token = "0x6001B31")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E7C550", Offset = "0x1E7C550", Length = "0x1A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectPropertyDescriptor), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(PropertyDescriptor),
			typeof(Attribute[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExtendedPropertyDescriptor), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(PropertyDescriptor),
			typeof(Attribute[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static PropertyDescriptor CreateProperty(Type componentType, PropertyDescriptor oldPropertyDescriptor, params Attribute[] attributes)
		{
			throw null;
		}

		// Token: 0x060018A9 RID: 6313 RVA: 0x00007385 File Offset: 0x00005585
		[Conditional("DEBUG")]
		[global::Cpp2ILInjected.Token(Token = "0x6001B32")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E7C6F4", Offset = "0x1E7C6F4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static void DebugValidate(Type type, AttributeCollection attributes, AttributeCollection debugAttributes)
		{
			throw null;
		}

		// Token: 0x060018AA RID: 6314 RVA: 0x00007388 File Offset: 0x00005588
		[Conditional("DEBUG")]
		[global::Cpp2ILInjected.Token(Token = "0x6001B33")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E7C6F8", Offset = "0x1E7C6F8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static void DebugValidate(AttributeCollection attributes, AttributeCollection debugAttributes)
		{
			throw null;
		}

		// Token: 0x060018AB RID: 6315 RVA: 0x0000738B File Offset: 0x0000558B
		[Conditional("DEBUG")]
		[global::Cpp2ILInjected.Token(Token = "0x6001B34")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E7C6FC", Offset = "0x1E7C6FC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static void DebugValidate(AttributeCollection attributes, Type type)
		{
			throw null;
		}

		// Token: 0x060018AC RID: 6316 RVA: 0x0000738E File Offset: 0x0000558E
		[Conditional("DEBUG")]
		[global::Cpp2ILInjected.Token(Token = "0x6001B35")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E7C700", Offset = "0x1E7C700", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static void DebugValidate(AttributeCollection attributes, object instance, bool noCustomTypeDesc)
		{
			throw null;
		}

		// Token: 0x060018AD RID: 6317 RVA: 0x00007391 File Offset: 0x00005591
		[Conditional("DEBUG")]
		[global::Cpp2ILInjected.Token(Token = "0x6001B36")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E7C704", Offset = "0x1E7C704", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static void DebugValidate(TypeConverter converter, Type type)
		{
			throw null;
		}

		// Token: 0x060018AE RID: 6318 RVA: 0x00007394 File Offset: 0x00005594
		[Conditional("DEBUG")]
		[global::Cpp2ILInjected.Token(Token = "0x6001B37")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E7C708", Offset = "0x1E7C708", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static void DebugValidate(TypeConverter converter, object instance, bool noCustomTypeDesc)
		{
			throw null;
		}

		// Token: 0x060018AF RID: 6319 RVA: 0x00007397 File Offset: 0x00005597
		[Conditional("DEBUG")]
		[global::Cpp2ILInjected.Token(Token = "0x6001B38")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E7C70C", Offset = "0x1E7C70C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static void DebugValidate(EventDescriptorCollection events, Type type, Attribute[] attributes)
		{
			throw null;
		}

		// Token: 0x060018B0 RID: 6320 RVA: 0x0000739A File Offset: 0x0000559A
		[Conditional("DEBUG")]
		[global::Cpp2ILInjected.Token(Token = "0x6001B39")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E7C710", Offset = "0x1E7C710", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static void DebugValidate(EventDescriptorCollection events, object instance, Attribute[] attributes, bool noCustomTypeDesc)
		{
			throw null;
		}

		// Token: 0x060018B1 RID: 6321 RVA: 0x0000739D File Offset: 0x0000559D
		[Conditional("DEBUG")]
		[global::Cpp2ILInjected.Token(Token = "0x6001B3A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E7C714", Offset = "0x1E7C714", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static void DebugValidate(PropertyDescriptorCollection properties, Type type, Attribute[] attributes)
		{
			throw null;
		}

		// Token: 0x060018B2 RID: 6322 RVA: 0x000073A0 File Offset: 0x000055A0
		[Conditional("DEBUG")]
		[global::Cpp2ILInjected.Token(Token = "0x6001B3B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E7C718", Offset = "0x1E7C718", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static void DebugValidate(PropertyDescriptorCollection properties, object instance, Attribute[] attributes, bool noCustomTypeDesc)
		{
			throw null;
		}

		// Token: 0x060018B3 RID: 6323 RVA: 0x000073A3 File Offset: 0x000055A3
		[global::Cpp2ILInjected.Token(Token = "0x6001B3C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E7C71C", Offset = "0x1E7C71C", Length = "0x348")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetEvents", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Attribute[])
		}, ReturnType = typeof(EventDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetProperties", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Attribute[])
		}, ReturnType = typeof(PropertyDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "PipelineAttributeFilter", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ICollection),
			typeof(Attribute[]),
			typeof(object),
			typeof(IDictionary)
		}, ReturnType = typeof(ICollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "ShouldHideMember", MemberParameters = new object[]
		{
			typeof(MemberDescriptor),
			typeof(Attribute)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private static ArrayList FilterMembers(IList members, Attribute[] attributes)
		{
			throw null;
		}

		// Token: 0x060018B4 RID: 6324 RVA: 0x000073A6 File Offset: 0x000055A6
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[global::Cpp2ILInjected.Token(Token = "0x6001B3D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E69074", Offset = "0x1E69074", Length = "0x68C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MemberDescriptor), Member = "GetInvokee", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetPropertyOwner", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(object),
			typeof(PropertyDescriptor)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 39)]
		public static object GetAssociation(Type type, object primary)
		{
			throw null;
		}

		// Token: 0x060018B5 RID: 6325 RVA: 0x000073A9 File Offset: 0x000055A9
		[global::Cpp2ILInjected.Token(Token = "0x6001B3E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E6D90C", Offset = "0x1E6D90C", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "FillAttributes", MemberParameters = new object[] { typeof(IList) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider.ReflectedTypeData", Member = "GetAttributes", ReturnType = typeof(AttributeCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider.ReflectedTypeData", Member = "GetConverter", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(TypeConverter))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider.ReflectedTypeData", Member = "GetDefaultEvent", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(EventDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider.ReflectedTypeData", Member = "GetDefaultProperty", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(PropertyDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider.ReflectedTypeData", Member = "GetEditor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "ReflectGetExtendedProperties", MemberParameters = new object[] { typeof(IExtenderProvider) }, ReturnType = typeof(PropertyDescriptor[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AttributeCollection), Member = ".ctor", MemberParameters = new object[] { typeof(Attribute[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetDescriptor", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(string)
		}, ReturnType = typeof(ICustomTypeDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static AttributeCollection GetAttributes(Type componentType)
		{
			throw null;
		}

		// Token: 0x060018B6 RID: 6326 RVA: 0x000073AC File Offset: 0x000055AC
		[global::Cpp2ILInjected.Token(Token = "0x6001B3F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E63E0C", Offset = "0x1E63E0C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Container), Member = "ValidateName", MemberParameters = new object[]
		{
			typeof(IComponent),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider.ReflectedTypeData", Member = "GetConverter", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(TypeConverter))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider.ReflectedTypeData", Member = "GetDefaultEvent", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(EventDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider.ReflectedTypeData", Member = "GetDefaultProperty", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(PropertyDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider.ReflectedTypeData", Member = "GetEditor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "CreateDesigner", MemberParameters = new object[]
		{
			typeof(IComponent),
			typeof(Type)
		}, ReturnType = typeof(IDesigner))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(AttributeCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static AttributeCollection GetAttributes(object component)
		{
			throw null;
		}

		// Token: 0x060018B7 RID: 6327 RVA: 0x000073AF File Offset: 0x000055AF
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[global::Cpp2ILInjected.Token(Token = "0x6001B40")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E7CBC8", Offset = "0x1E7CBC8", Length = "0x408")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(AttributeCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetDescriptor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(ICustomTypeDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetExtendedDescriptor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(ICustomTypeDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetCache", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(IDictionary))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "PipelineInitialize", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ICollection),
			typeof(IDictionary)
		}, ReturnType = typeof(ICollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "PipelineMerge", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ICollection),
			typeof(ICollection),
			typeof(object),
			typeof(IDictionary)
		}, ReturnType = typeof(ICollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "PipelineFilter", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ICollection),
			typeof(object),
			typeof(IDictionary)
		}, ReturnType = typeof(ICollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AttributeCollection), Member = ".ctor", MemberParameters = new object[] { typeof(Attribute[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public static AttributeCollection GetAttributes(object component, bool noCustomTypeDesc)
		{
			throw null;
		}

		// Token: 0x060018B8 RID: 6328 RVA: 0x000073B2 File Offset: 0x000055B2
		[global::Cpp2ILInjected.Token(Token = "0x6001B41")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E72C4C", Offset = "0x1E72C4C", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetExtendedProperties", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(PropertyDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetExtenderProviders", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(IExtenderProvider[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "ReflectGetExtendedProperties", MemberParameters = new object[] { typeof(IExtenderProvider) }, ReturnType = typeof(PropertyDescriptor[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(AttributeCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetEvents", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Attribute[]),
			typeof(bool)
		}, ReturnType = typeof(EventDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetPropertiesImpl", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Attribute[]),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(PropertyDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "Refresh", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "NodeFor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(TypeDescriptor.TypeDescriptionNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static IDictionary GetCache(object instance)
		{
			throw null;
		}

		// Token: 0x060018B9 RID: 6329 RVA: 0x000073B5 File Offset: 0x000055B5
		[global::Cpp2ILInjected.Token(Token = "0x6001B42")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E80208", Offset = "0x1E80208", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static string GetClassName(object component)
		{
			throw null;
		}

		// Token: 0x060018BA RID: 6330 RVA: 0x000073B8 File Offset: 0x000055B8
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[global::Cpp2ILInjected.Token(Token = "0x6001B43")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E80260", Offset = "0x1E80260", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetDescriptor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(ICustomTypeDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static string GetClassName(object component, bool noCustomTypeDesc)
		{
			throw null;
		}

		// Token: 0x060018BB RID: 6331 RVA: 0x000073BB File Offset: 0x000055BB
		[global::Cpp2ILInjected.Token(Token = "0x6001B44")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E80338", Offset = "0x1E80338", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetDescriptor", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(string)
		}, ReturnType = typeof(ICustomTypeDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static string GetClassName(Type componentType)
		{
			throw null;
		}

		// Token: 0x060018BC RID: 6332 RVA: 0x000073BE File Offset: 0x000055BE
		[global::Cpp2ILInjected.Token(Token = "0x6001B45")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E74B70", Offset = "0x1E74B70", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetComponentName", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static string GetComponentName(object component)
		{
			throw null;
		}

		// Token: 0x060018BD RID: 6333 RVA: 0x000073C1 File Offset: 0x000055C1
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[global::Cpp2ILInjected.Token(Token = "0x6001B46")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E80418", Offset = "0x1E80418", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetComponentName", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetDescriptor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(ICustomTypeDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static string GetComponentName(object component, bool noCustomTypeDesc)
		{
			throw null;
		}

		// Token: 0x060018BE RID: 6334 RVA: 0x000073C4 File Offset: 0x000055C4
		[global::Cpp2ILInjected.Token(Token = "0x6001B47")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E804F0", Offset = "0x1E804F0", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static TypeConverter GetConverter(object component)
		{
			throw null;
		}

		// Token: 0x060018BF RID: 6335 RVA: 0x000073C7 File Offset: 0x000055C7
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[global::Cpp2ILInjected.Token(Token = "0x6001B48")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E80548", Offset = "0x1E80548", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetDescriptor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(ICustomTypeDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static TypeConverter GetConverter(object component, bool noCustomTypeDesc)
		{
			throw null;
		}

		// Token: 0x060018C0 RID: 6336 RVA: 0x000073CA File Offset: 0x000055CA
		[global::Cpp2ILInjected.Token(Token = "0x6001B49")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E80620", Offset = "0x1E80620", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbientValueAttribute), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InheritanceAttribute), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NullableConverter), Member = ".ctor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PropertyDescriptor), Member = "get_Converter", ReturnType = typeof(TypeConverter))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "ConvertFromInvariantString", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.JsonTypeReflector", Member = "GetTypeConverter", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(TypeConverter))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetDescriptor", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(string)
		}, ReturnType = typeof(ICustomTypeDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static TypeConverter GetConverter(Type type)
		{
			throw null;
		}

		// Token: 0x060018C1 RID: 6337 RVA: 0x000073CD File Offset: 0x000055CD
		[global::Cpp2ILInjected.Token(Token = "0x6001B4A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E80700", Offset = "0x1E80700", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetConverter", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(TypeConverter))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter), Member = "ConvertFromInvariantString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static object ConvertFromInvariantString(Type type, string stringValue)
		{
			throw null;
		}

		// Token: 0x060018C2 RID: 6338 RVA: 0x000073D0 File Offset: 0x000055D0
		[global::Cpp2ILInjected.Token(Token = "0x6001B4B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E80768", Offset = "0x1E80768", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetDescriptor", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(string)
		}, ReturnType = typeof(ICustomTypeDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static EventDescriptor GetDefaultEvent(Type componentType)
		{
			throw null;
		}

		// Token: 0x060018C3 RID: 6339 RVA: 0x000073D3 File Offset: 0x000055D3
		[global::Cpp2ILInjected.Token(Token = "0x6001B4C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E80890", Offset = "0x1E80890", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static EventDescriptor GetDefaultEvent(object component)
		{
			throw null;
		}

		// Token: 0x060018C4 RID: 6340 RVA: 0x000073D6 File Offset: 0x000055D6
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[global::Cpp2ILInjected.Token(Token = "0x6001B4D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E808E8", Offset = "0x1E808E8", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetDescriptor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(ICustomTypeDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static EventDescriptor GetDefaultEvent(object component, bool noCustomTypeDesc)
		{
			throw null;
		}

		// Token: 0x060018C5 RID: 6341 RVA: 0x000073D9 File Offset: 0x000055D9
		[global::Cpp2ILInjected.Token(Token = "0x6001B4E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E809CC", Offset = "0x1E809CC", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetDescriptor", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(string)
		}, ReturnType = typeof(ICustomTypeDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static PropertyDescriptor GetDefaultProperty(Type componentType)
		{
			throw null;
		}

		// Token: 0x060018C6 RID: 6342 RVA: 0x000073DC File Offset: 0x000055DC
		[global::Cpp2ILInjected.Token(Token = "0x6001B4F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E80AF4", Offset = "0x1E80AF4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static PropertyDescriptor GetDefaultProperty(object component)
		{
			throw null;
		}

		// Token: 0x060018C7 RID: 6343 RVA: 0x000073DF File Offset: 0x000055DF
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[global::Cpp2ILInjected.Token(Token = "0x6001B50")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E80B4C", Offset = "0x1E80B4C", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetDescriptor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(ICustomTypeDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static PropertyDescriptor GetDefaultProperty(object component, bool noCustomTypeDesc)
		{
			throw null;
		}

		// Token: 0x060018C8 RID: 6344 RVA: 0x000073E2 File Offset: 0x000055E2
		[global::Cpp2ILInjected.Token(Token = "0x6001B51")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E7CAEC", Offset = "0x1E7CAEC", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(AttributeCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetClassName", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetConverter", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(TypeConverter))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetDefaultEvent", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(EventDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetDefaultProperty", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(PropertyDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetEditor", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetEvents", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(EventDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetEvents", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Attribute[])
		}, ReturnType = typeof(EventDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetProperties", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(PropertyDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetProperties", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Attribute[])
		}, ReturnType = typeof(PropertyDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "NodeFor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(TypeDescriptor.TypeDescriptionNode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptionProvider), Member = "GetTypeDescriptor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(ICustomTypeDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal static ICustomTypeDescriptor GetDescriptor(Type type, string typeName)
		{
			throw null;
		}

		// Token: 0x060018C9 RID: 6345 RVA: 0x000073E5 File Offset: 0x000055E5
		[global::Cpp2ILInjected.Token(Token = "0x6001B52")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E7CFD0", Offset = "0x1E7CFD0", Length = "0x1DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(AttributeCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetClassName", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetComponentName", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetConverter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(TypeConverter))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetDefaultEvent", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(EventDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetDefaultProperty", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(PropertyDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetEditor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetEvents", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Attribute[]),
			typeof(bool)
		}, ReturnType = typeof(EventDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetPropertiesImpl", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Attribute[]),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(PropertyDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "NodeFor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(TypeDescriptor.TypeDescriptionNode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptionProvider), Member = "GetTypeDescriptor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(ICustomTypeDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor.MergedTypeDescriptor), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(ICustomTypeDescriptor),
			typeof(ICustomTypeDescriptor)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		internal static ICustomTypeDescriptor GetDescriptor(object component, bool noCustomTypeDesc)
		{
			throw null;
		}

		// Token: 0x060018CA RID: 6346 RVA: 0x000073E8 File Offset: 0x000055E8
		[global::Cpp2ILInjected.Token(Token = "0x6001B53")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E7D1AC", Offset = "0x1E7D1AC", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(AttributeCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetEvents", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Attribute[]),
			typeof(bool)
		}, ReturnType = typeof(EventDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetPropertiesImpl", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Attribute[]),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(PropertyDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "NodeFor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(TypeDescriptor.TypeDescriptionNode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal static ICustomTypeDescriptor GetExtendedDescriptor(object component)
		{
			throw null;
		}

		// Token: 0x060018CB RID: 6347 RVA: 0x000073EB File Offset: 0x000055EB
		[global::Cpp2ILInjected.Token(Token = "0x6001B54")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E80C30", Offset = "0x1E80C30", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static object GetEditor(object component, Type editorBaseType)
		{
			throw null;
		}

		// Token: 0x060018CC RID: 6348 RVA: 0x000073EE File Offset: 0x000055EE
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[global::Cpp2ILInjected.Token(Token = "0x6001B55")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E80C98", Offset = "0x1E80C98", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetDescriptor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(ICustomTypeDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public static object GetEditor(object component, Type editorBaseType, bool noCustomTypeDesc)
		{
			throw null;
		}

		// Token: 0x060018CD RID: 6349 RVA: 0x000073F1 File Offset: 0x000055F1
		[global::Cpp2ILInjected.Token(Token = "0x6001B56")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E80DF8", Offset = "0x1E80DF8", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PropertyDescriptor), Member = "GetEditor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetDescriptor", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(string)
		}, ReturnType = typeof(ICustomTypeDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public static object GetEditor(Type type, Type editorBaseType)
		{
			throw null;
		}

		// Token: 0x060018CE RID: 6350 RVA: 0x000073F4 File Offset: 0x000055F4
		[global::Cpp2ILInjected.Token(Token = "0x6001B57")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E6A64C", Offset = "0x1E6A64C", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "get_ChangedEventValue", ReturnType = typeof(EventDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "get_IPropChangedEventValue", ReturnType = typeof(EventDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider.ReflectedTypeData", Member = "GetDefaultEvent", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(EventDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventDescriptorCollection), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(EventDescriptor[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetDescriptor", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(string)
		}, ReturnType = typeof(ICustomTypeDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static EventDescriptorCollection GetEvents(Type componentType)
		{
			throw null;
		}

		// Token: 0x060018CF RID: 6351 RVA: 0x000073F7 File Offset: 0x000055F7
		[global::Cpp2ILInjected.Token(Token = "0x6001B58")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E80F68", Offset = "0x1E80F68", Length = "0x254")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventDescriptorCollection), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(EventDescriptor[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetDescriptor", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(string)
		}, ReturnType = typeof(ICustomTypeDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "FilterMembers", MemberParameters = new object[]
		{
			typeof(IList),
			typeof(Attribute[])
		}, ReturnType = typeof(ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public static EventDescriptorCollection GetEvents(Type componentType, Attribute[] attributes)
		{
			throw null;
		}

		// Token: 0x060018D0 RID: 6352 RVA: 0x000073FA File Offset: 0x000055FA
		[global::Cpp2ILInjected.Token(Token = "0x6001B59")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E771F8", Offset = "0x1E771F8", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider.ReflectedTypeData", Member = "GetDefaultEvent", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(EventDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetEvents", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Attribute[]),
			typeof(bool)
		}, ReturnType = typeof(EventDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static EventDescriptorCollection GetEvents(object component)
		{
			throw null;
		}

		// Token: 0x060018D1 RID: 6353 RVA: 0x000073FD File Offset: 0x000055FD
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[global::Cpp2ILInjected.Token(Token = "0x6001B5A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E81698", Offset = "0x1E81698", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetEvents", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Attribute[]),
			typeof(bool)
		}, ReturnType = typeof(EventDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static EventDescriptorCollection GetEvents(object component, bool noCustomTypeDesc)
		{
			throw null;
		}

		// Token: 0x060018D2 RID: 6354 RVA: 0x00007400 File Offset: 0x00005600
		[global::Cpp2ILInjected.Token(Token = "0x6001B5B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E81700", Offset = "0x1E81700", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetEvents", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Attribute[]),
			typeof(bool)
		}, ReturnType = typeof(EventDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static EventDescriptorCollection GetEvents(object component, Attribute[] attributes)
		{
			throw null;
		}

		// Token: 0x060018D3 RID: 6355 RVA: 0x00007403 File Offset: 0x00005603
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[global::Cpp2ILInjected.Token(Token = "0x6001B5C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E811BC", Offset = "0x1E811BC", Length = "0x4DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetEvents", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(EventDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetEvents", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(EventDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetEvents", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Attribute[])
		}, ReturnType = typeof(EventDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetDescriptor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(ICustomTypeDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventDescriptorCollection), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(EventDescriptor[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetCache", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(IDictionary))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetExtendedDescriptor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(ICustomTypeDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "PipelineFilter", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ICollection),
			typeof(object),
			typeof(IDictionary)
		}, ReturnType = typeof(ICollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "PipelineInitialize", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ICollection),
			typeof(IDictionary)
		}, ReturnType = typeof(ICollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "PipelineMerge", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ICollection),
			typeof(ICollection),
			typeof(object),
			typeof(IDictionary)
		}, ReturnType = typeof(ICollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "PipelineAttributeFilter", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ICollection),
			typeof(Attribute[]),
			typeof(object),
			typeof(IDictionary)
		}, ReturnType = typeof(ICollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public static EventDescriptorCollection GetEvents(object component, Attribute[] attributes, bool noCustomTypeDesc)
		{
			throw null;
		}

		// Token: 0x060018D4 RID: 6356 RVA: 0x00007406 File Offset: 0x00005606
		[global::Cpp2ILInjected.Token(Token = "0x6001B5D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E81D78", Offset = "0x1E81D78", Length = "0x300")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "PipelineFilter", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ICollection),
			typeof(object),
			typeof(IDictionary)
		}, ReturnType = typeof(ICollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(IFormatProvider),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private static string GetExtenderCollisionSuffix(MemberDescriptor member)
		{
			throw null;
		}

		// Token: 0x060018D5 RID: 6357 RVA: 0x00007409 File Offset: 0x00005609
		[global::Cpp2ILInjected.Token(Token = "0x6001B5E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E82078", Offset = "0x1E82078", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetProvider", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(TypeDescriptionProvider))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static string GetFullComponentName(object component)
		{
			throw null;
		}

		// Token: 0x060018D6 RID: 6358 RVA: 0x0000740C File Offset: 0x0000560C
		[global::Cpp2ILInjected.Token(Token = "0x6001B5F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E82128", Offset = "0x1E82128", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "NodeFor", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(bool)
		}, ReturnType = typeof(TypeDescriptor.TypeDescriptionNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "get_IsInterface", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "get_InterfaceType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static Type GetNodeForBaseType(Type searchType)
		{
			throw null;
		}

		// Token: 0x060018D7 RID: 6359 RVA: 0x0000740F File Offset: 0x0000560F
		[global::Cpp2ILInjected.Token(Token = "0x6001B60")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E772AC", Offset = "0x1E772AC", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BindingList<>), Member = "Child_PropertyChanged", MemberParameters = new object[]
		{
			typeof(object),
			typeof(PropertyChangedEventArgs)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider.ReflectedTypeData", Member = "GetDefaultProperty", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(PropertyDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyDescriptorCollection), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(PropertyDescriptor[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetDescriptor", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(string)
		}, ReturnType = typeof(ICustomTypeDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static PropertyDescriptorCollection GetProperties(Type componentType)
		{
			throw null;
		}

		// Token: 0x060018D8 RID: 6360 RVA: 0x00007412 File Offset: 0x00005612
		[global::Cpp2ILInjected.Token(Token = "0x6001B61")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E821F4", Offset = "0x1E821F4", Length = "0x254")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PropertyDescriptor), Member = "GetChildProperties", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Attribute[])
		}, ReturnType = typeof(PropertyDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyDescriptorCollection), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(PropertyDescriptor[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetDescriptor", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(string)
		}, ReturnType = typeof(ICustomTypeDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "FilterMembers", MemberParameters = new object[]
		{
			typeof(IList),
			typeof(Attribute[])
		}, ReturnType = typeof(ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public static PropertyDescriptorCollection GetProperties(Type componentType, Attribute[] attributes)
		{
			throw null;
		}

		// Token: 0x060018D9 RID: 6361 RVA: 0x00007415 File Offset: 0x00005615
		[global::Cpp2ILInjected.Token(Token = "0x6001B62")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E77254", Offset = "0x1E77254", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Utils", Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Localization.LocalizedText", Member = "FormatWith", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Localization.LocalizedText", Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(object),
			typeof(StringBuilder)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Localization.LocalizedText", Member = "CanFormatWith", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ComponentResourceManager), Member = "ApplyResources", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string),
			typeof(CultureInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider.ReflectedTypeData", Member = "GetDefaultProperty", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(PropertyDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetProperties", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(PropertyDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static PropertyDescriptorCollection GetProperties(object component)
		{
			throw null;
		}

		// Token: 0x060018DA RID: 6362 RVA: 0x00007418 File Offset: 0x00005618
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[global::Cpp2ILInjected.Token(Token = "0x6001B63")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E82448", Offset = "0x1E82448", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetProperties", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(PropertyDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static PropertyDescriptorCollection GetProperties(object component, bool noCustomTypeDesc)
		{
			throw null;
		}

		// Token: 0x060018DB RID: 6363 RVA: 0x0000741B File Offset: 0x0000561B
		[global::Cpp2ILInjected.Token(Token = "0x6001B64")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E62A88", Offset = "0x1E62A88", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExpandableObjectConverter), Member = "GetProperties", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(object),
			typeof(Attribute[])
		}, ReturnType = typeof(PropertyDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PropertyDescriptor), Member = "GetChildProperties", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Attribute[])
		}, ReturnType = typeof(PropertyDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetProperties", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Attribute[]),
			typeof(bool)
		}, ReturnType = typeof(PropertyDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static PropertyDescriptorCollection GetProperties(object component, Attribute[] attributes)
		{
			throw null;
		}

		// Token: 0x060018DC RID: 6364 RVA: 0x0000741E File Offset: 0x0000561E
		[global::Cpp2ILInjected.Token(Token = "0x6001B65")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E82AFC", Offset = "0x1E82AFC", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetProperties", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Attribute[])
		}, ReturnType = typeof(PropertyDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetPropertiesImpl", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Attribute[]),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(PropertyDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static PropertyDescriptorCollection GetProperties(object component, Attribute[] attributes, bool noCustomTypeDesc)
		{
			throw null;
		}

		// Token: 0x060018DD RID: 6365 RVA: 0x00007421 File Offset: 0x00005621
		[global::Cpp2ILInjected.Token(Token = "0x6001B66")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E824B4", Offset = "0x1E824B4", Length = "0x648")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetProperties", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Attribute[]),
			typeof(bool)
		}, ReturnType = typeof(PropertyDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetDescriptor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(ICustomTypeDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyDescriptorCollection), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(PropertyDescriptor[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetCache", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(IDictionary))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetExtendedDescriptor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(ICustomTypeDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "PipelineFilter", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ICollection),
			typeof(object),
			typeof(IDictionary)
		}, ReturnType = typeof(ICollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "PipelineInitialize", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ICollection),
			typeof(IDictionary)
		}, ReturnType = typeof(ICollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "PipelineMerge", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ICollection),
			typeof(ICollection),
			typeof(object),
			typeof(IDictionary)
		}, ReturnType = typeof(ICollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "PipelineAttributeFilter", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ICollection),
			typeof(Attribute[]),
			typeof(object),
			typeof(IDictionary)
		}, ReturnType = typeof(ICollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
		private static PropertyDescriptorCollection GetPropertiesImpl(object component, Attribute[] attributes, bool noCustomTypeDesc, bool noAttributes)
		{
			throw null;
		}

		// Token: 0x060018DE RID: 6366 RVA: 0x00007424 File Offset: 0x00005624
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[global::Cpp2ILInjected.Token(Token = "0x6001B67")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E794C0", Offset = "0x1E794C0", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "AddAttributes", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Attribute[])
		}, ReturnType = typeof(TypeDescriptionProvider))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "NodeFor", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(bool)
		}, ReturnType = typeof(TypeDescriptor.TypeDescriptionNode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static TypeDescriptionProvider GetProvider(Type type)
		{
			throw null;
		}

		// Token: 0x060018DF RID: 6367 RVA: 0x00007427 File Offset: 0x00005627
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[global::Cpp2ILInjected.Token(Token = "0x6001B68")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E796B4", Offset = "0x1E796B4", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "AddAttributes", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Attribute[])
		}, ReturnType = typeof(TypeDescriptionProvider))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetFullComponentName", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "NodeFor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(TypeDescriptor.TypeDescriptionNode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static TypeDescriptionProvider GetProvider(object instance)
		{
			throw null;
		}

		// Token: 0x060018E0 RID: 6368 RVA: 0x0000742A File Offset: 0x0000562A
		[global::Cpp2ILInjected.Token(Token = "0x6001B69")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E82B6C", Offset = "0x1E82B6C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DelegatingTypeDescriptionProvider), Member = "get_Provider", ReturnType = typeof(TypeDescriptionProvider))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "NodeFor", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(bool)
		}, ReturnType = typeof(TypeDescriptor.TypeDescriptionNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static TypeDescriptionProvider GetProviderRecursive(Type type)
		{
			throw null;
		}

		// Token: 0x060018E1 RID: 6369 RVA: 0x0000742D File Offset: 0x0000562D
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[global::Cpp2ILInjected.Token(Token = "0x6001B6A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E66DE8", Offset = "0x1E66DE8", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AttributeCollection), Member = "GetDefaultAttribute", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(Attribute))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EnumConverter), Member = "GetStandardValues", MemberParameters = new object[] { typeof(ITypeDescriptorContext) }, ReturnType = typeof(TypeConverter.StandardValuesCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "NodeFor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(TypeDescriptor.TypeDescriptionNode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptionProvider), Member = "GetReflectionType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static Type GetReflectionType(Type type)
		{
			throw null;
		}

		// Token: 0x060018E2 RID: 6370 RVA: 0x00007430 File Offset: 0x00005630
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[global::Cpp2ILInjected.Token(Token = "0x6001B6B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E82BC4", Offset = "0x1E82BC4", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "NodeFor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(TypeDescriptor.TypeDescriptionNode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptionProvider), Member = "GetReflectionType", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static Type GetReflectionType(object instance)
		{
			throw null;
		}

		// Token: 0x060018E3 RID: 6371 RVA: 0x00007433 File Offset: 0x00005633
		[global::Cpp2ILInjected.Token(Token = "0x6001B6C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E78D64", Offset = "0x1E78D64", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "get_ComNativeDescriptorHandler", ReturnType = typeof(IComNativeDescriptorHandler))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "set_ComNativeDescriptorHandler", MemberParameters = new object[] { typeof(IComNativeDescriptorHandler) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "CreateInstance", MemberParameters = new object[]
		{
			typeof(IServiceProvider),
			typeof(Type),
			typeof(Type[]),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetDescriptor", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(string)
		}, ReturnType = typeof(ICustomTypeDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetReflectionType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "NodeFor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(TypeDescriptor.TypeDescriptionNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "NodeFor", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(bool)
		}, ReturnType = typeof(TypeDescriptor.TypeDescriptionNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static TypeDescriptor.TypeDescriptionNode NodeFor(Type type)
		{
			throw null;
		}

		// Token: 0x060018E4 RID: 6372 RVA: 0x00007436 File Offset: 0x00005636
		[global::Cpp2ILInjected.Token(Token = "0x6001B6D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E79A20", Offset = "0x1E79A20", Length = "0x4C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "AddProvider", MemberParameters = new object[]
		{
			typeof(TypeDescriptionProvider),
			typeof(Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetProvider", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(TypeDescriptionProvider))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetProviderRecursive", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(TypeDescriptionProvider))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "NodeFor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(TypeDescriptor.TypeDescriptionNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "CheckDefaultProvider", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetNodeForBaseType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptionProvider), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor.TypeDescriptionNode), Member = ".ctor", MemberParameters = new object[] { typeof(TypeDescriptionProvider) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DelegatingTypeDescriptionProvider), Member = ".ctor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 33)]
		private static TypeDescriptor.TypeDescriptionNode NodeFor(Type type, bool createDelegator)
		{
			throw null;
		}

		// Token: 0x060018E5 RID: 6373 RVA: 0x00007439 File Offset: 0x00005639
		[global::Cpp2ILInjected.Token(Token = "0x6001B6E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E801B0", Offset = "0x1E801B0", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetCache", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(IDictionary))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetDescriptor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(ICustomTypeDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetExtendedDescriptor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(ICustomTypeDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetReflectionType", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "NodeFor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(TypeDescriptor.TypeDescriptionNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static TypeDescriptor.TypeDescriptionNode NodeFor(object instance)
		{
			throw null;
		}

		// Token: 0x060018E6 RID: 6374 RVA: 0x0000743C File Offset: 0x0000563C
		[global::Cpp2ILInjected.Token(Token = "0x6001B6F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E7A4DC", Offset = "0x1E7A4DC", Length = "0x14C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "AddProvider", MemberParameters = new object[]
		{
			typeof(TypeDescriptionProvider),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetProvider", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(TypeDescriptionProvider))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "NodeFor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(TypeDescriptor.TypeDescriptionNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "get_IsCOMObject", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "get_ComObjectType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DelegatingTypeDescriptionProvider), Member = ".ctor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor.TypeDescriptionNode), Member = ".ctor", MemberParameters = new object[] { typeof(TypeDescriptionProvider) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "NodeFor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(TypeDescriptor.TypeDescriptionNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static TypeDescriptor.TypeDescriptionNode NodeFor(object instance, bool createDelegator)
		{
			throw null;
		}

		// Token: 0x060018E7 RID: 6375 RVA: 0x0000743F File Offset: 0x0000563F
		[global::Cpp2ILInjected.Token(Token = "0x6001B70")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E82C70", Offset = "0x1E82C70", Length = "0x330")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "RemoveProvider", MemberParameters = new object[]
		{
			typeof(TypeDescriptionProvider),
			typeof(Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "RemoveProvider", MemberParameters = new object[]
		{
			typeof(TypeDescriptionProvider),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DelegatingTypeDescriptionProvider), Member = ".ctor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		private static void NodeRemove(object key, TypeDescriptionProvider provider)
		{
			throw null;
		}

		// Token: 0x060018E8 RID: 6376 RVA: 0x00007442 File Offset: 0x00005642
		[global::Cpp2ILInjected.Token(Token = "0x6001B71")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E81768", Offset = "0x1E81768", Length = "0x610")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetEvents", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Attribute[]),
			typeof(bool)
		}, ReturnType = typeof(EventDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetPropertiesImpl", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Attribute[]),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(PropertyDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor.AttributeFilterCacheItem), Member = "IsValid", MemberParameters = new object[] { typeof(Attribute[]) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", MemberParameters = new object[] { typeof(ICollection) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "FilterMembers", MemberParameters = new object[]
		{
			typeof(IList),
			typeof(Attribute[])
		}, ReturnType = typeof(ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyDescriptorCollection), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(PropertyDescriptor[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventDescriptorCollection), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(EventDescriptor[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor.AttributeFilterCacheItem), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Attribute[]),
			typeof(ICollection)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
		private static ICollection PipelineAttributeFilter(int pipelineType, ICollection members, Attribute[] filter, object instance, IDictionary cache)
		{
			throw null;
		}

		// Token: 0x060018E9 RID: 6377 RVA: 0x00007445 File Offset: 0x00005645
		[global::Cpp2ILInjected.Token(Token = "0x6001B72")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E7E310", Offset = "0x1E7E310", Length = "0x17F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(AttributeCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetEvents", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Attribute[]),
			typeof(bool)
		}, ReturnType = typeof(EventDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetPropertiesImpl", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Attribute[]),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(PropertyDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor.FilterCacheItem), Member = "IsValid", MemberParameters = new object[] { typeof(ITypeDescriptorFilterService) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OrderedDictionary), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OrderedDictionary), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OrderedDictionary), Member = "Contains", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetExtenderCollisionSuffix", MemberParameters = new object[] { typeof(MemberDescriptor) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OrderedDictionary), Member = "get_Item", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OrderedDictionary), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OrderedDictionary), Member = "get_Values", ReturnType = typeof(ICollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", MemberParameters = new object[] { typeof(ICollection) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyDescriptorCollection), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(PropertyDescriptor[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventDescriptorCollection), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(EventDescriptor[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AttributeCollection), Member = ".ctor", MemberParameters = new object[] { typeof(Attribute[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor.FilterCacheItem), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorFilterService),
			typeof(ICollection)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 133)]
		private static ICollection PipelineFilter(int pipelineType, ICollection members, object instance, IDictionary cache)
		{
			throw null;
		}

		// Token: 0x060018EA RID: 6378 RVA: 0x00007448 File Offset: 0x00005648
		[global::Cpp2ILInjected.Token(Token = "0x6001B73")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E7FB00", Offset = "0x1E7FB00", Length = "0x6B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(AttributeCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetEvents", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Attribute[]),
			typeof(bool)
		}, ReturnType = typeof(EventDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetPropertiesImpl", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Attribute[]),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(PropertyDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
		private static ICollection PipelineInitialize(int pipelineType, ICollection members, IDictionary cache)
		{
			throw null;
		}

		// Token: 0x060018EB RID: 6379 RVA: 0x0000744B File Offset: 0x0000564B
		[global::Cpp2ILInjected.Token(Token = "0x6001B74")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E7D25C", Offset = "0x1E7D25C", Length = "0x10B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(AttributeCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetEvents", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Attribute[]),
			typeof(bool)
		}, ReturnType = typeof(EventDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetPropertiesImpl", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Attribute[]),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(PropertyDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AttributeCollection), Member = ".ctor", MemberParameters = new object[] { typeof(Attribute[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyDescriptorCollection), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(PropertyDescriptor[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventDescriptorCollection), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(EventDescriptor[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 73)]
		private static ICollection PipelineMerge(int pipelineType, ICollection primary, ICollection secondary, object instance, IDictionary cache)
		{
			throw null;
		}

		// Token: 0x060018EC RID: 6380 RVA: 0x0000744E File Offset: 0x0000564E
		[global::Cpp2ILInjected.Token(Token = "0x6001B75")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E82FA0", Offset = "0x1E82FA0", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "Refresh", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "RemoveProvider", MemberParameters = new object[]
		{
			typeof(TypeDescriptionProvider),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RefreshEventArgs), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static void RaiseRefresh(object component)
		{
			throw null;
		}

		// Token: 0x060018ED RID: 6381 RVA: 0x00007451 File Offset: 0x00005651
		[global::Cpp2ILInjected.Token(Token = "0x6001B76")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8304C", Offset = "0x1E8304C", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "Refresh", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "Refresh", MemberParameters = new object[] { typeof(Module) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "RemoveProvider", MemberParameters = new object[]
		{
			typeof(TypeDescriptionProvider),
			typeof(Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RefreshEventArgs), Member = ".ctor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static void RaiseRefresh(Type type)
		{
			throw null;
		}

		// Token: 0x060018EE RID: 6382 RVA: 0x00007454 File Offset: 0x00005654
		[global::Cpp2ILInjected.Token(Token = "0x6001B77")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E830F8", Offset = "0x1E830F8", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "Refresh", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void Refresh(object component)
		{
			throw null;
		}

		// Token: 0x060018EF RID: 6383 RVA: 0x00007457 File Offset: 0x00005657
		[global::Cpp2ILInjected.Token(Token = "0x6001B78")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E7A628", Offset = "0x1E7A628", Length = "0x81C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "AddProvider", MemberParameters = new object[]
		{
			typeof(TypeDescriptionProvider),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "Refresh", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "IsPopulated", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetTypeData", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(bool)
		}, ReturnType = "System.ComponentModel.ReflectTypeDescriptionProvider.ReflectedTypeData")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetCache", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(IDictionary))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "RaiseRefresh", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 43)]
		private static void Refresh(object component, bool refreshReflectionProvider)
		{
			throw null;
		}

		// Token: 0x060018F0 RID: 6384 RVA: 0x0000745A File Offset: 0x0000565A
		[global::Cpp2ILInjected.Token(Token = "0x6001B79")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E79EE8", Offset = "0x1E79EE8", Length = "0x5F4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "AddProvider", MemberParameters = new object[]
		{
			typeof(TypeDescriptionProvider),
			typeof(Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "IsPopulated", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetTypeData", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(bool)
		}, ReturnType = "System.ComponentModel.ReflectTypeDescriptionProvider.ReflectedTypeData")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "RaiseRefresh", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 33)]
		public static void Refresh(Type type)
		{
			throw null;
		}

		// Token: 0x060018F1 RID: 6385 RVA: 0x0000745D File Offset: 0x0000565D
		[global::Cpp2ILInjected.Token(Token = "0x6001B7A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E83150", Offset = "0x1E83150", Length = "0x9A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "Refresh", MemberParameters = new object[] { typeof(Assembly) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Module), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Module),
			typeof(Module)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetPopulatedTypes", MemberParameters = new object[] { typeof(Module) }, ReturnType = typeof(Type[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetTypeData", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(bool)
		}, ReturnType = "System.ComponentModel.ReflectTypeDescriptionProvider.ReflectedTypeData")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "RaiseRefresh", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 51)]
		public static void Refresh(Module module)
		{
			throw null;
		}

		// Token: 0x060018F2 RID: 6386 RVA: 0x00007460 File Offset: 0x00005660
		[global::Cpp2ILInjected.Token(Token = "0x6001B7B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E83AF0", Offset = "0x1E83AF0", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Assembly), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Assembly),
			typeof(Assembly)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Assembly), Member = "GetModules", ReturnType = typeof(Module[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "Refresh", MemberParameters = new object[] { typeof(Module) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void Refresh(Assembly assembly)
		{
			throw null;
		}

		// Token: 0x060018F3 RID: 6387 RVA: 0x00007463 File Offset: 0x00005663
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[global::Cpp2ILInjected.Token(Token = "0x6001B7C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E83B9C", Offset = "0x1E83B9C", Length = "0x374")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		public static void RemoveAssociation(object primary, object secondary)
		{
			throw null;
		}

		// Token: 0x060018F4 RID: 6388 RVA: 0x00007466 File Offset: 0x00005666
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[global::Cpp2ILInjected.Token(Token = "0x6001B7D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E83F10", Offset = "0x1E83F10", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static void RemoveAssociations(object primary)
		{
			throw null;
		}

		// Token: 0x060018F5 RID: 6389 RVA: 0x00007469 File Offset: 0x00005669
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[global::Cpp2ILInjected.Token(Token = "0x6001B7E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E83FE0", Offset = "0x1E83FE0", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "RemoveProviderTransparent", MemberParameters = new object[]
		{
			typeof(TypeDescriptionProvider),
			typeof(Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "NodeRemove", MemberParameters = new object[]
		{
			typeof(object),
			typeof(TypeDescriptionProvider)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "RaiseRefresh", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public static void RemoveProvider(TypeDescriptionProvider provider, Type type)
		{
			throw null;
		}

		// Token: 0x060018F6 RID: 6390 RVA: 0x0000746C File Offset: 0x0000566C
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[global::Cpp2ILInjected.Token(Token = "0x6001B7F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E840E8", Offset = "0x1E840E8", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "RemoveProviderTransparent", MemberParameters = new object[]
		{
			typeof(TypeDescriptionProvider),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "NodeRemove", MemberParameters = new object[]
		{
			typeof(object),
			typeof(TypeDescriptionProvider)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "RaiseRefresh", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static void RemoveProvider(TypeDescriptionProvider provider, object instance)
		{
			throw null;
		}

		// Token: 0x060018F7 RID: 6391 RVA: 0x0000746F File Offset: 0x0000566F
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[global::Cpp2ILInjected.Token(Token = "0x6001B80")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E841BC", Offset = "0x1E841BC", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "RemoveProvider", MemberParameters = new object[]
		{
			typeof(TypeDescriptionProvider),
			typeof(Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public static void RemoveProviderTransparent(TypeDescriptionProvider provider, Type type)
		{
			throw null;
		}

		// Token: 0x060018F8 RID: 6392 RVA: 0x00007472 File Offset: 0x00005672
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[global::Cpp2ILInjected.Token(Token = "0x6001B81")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E842BC", Offset = "0x1E842BC", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "RemoveProvider", MemberParameters = new object[]
		{
			typeof(TypeDescriptionProvider),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static void RemoveProviderTransparent(TypeDescriptionProvider provider, object instance)
		{
			throw null;
		}

		// Token: 0x060018F9 RID: 6393 RVA: 0x00007475 File Offset: 0x00005675
		[global::Cpp2ILInjected.Token(Token = "0x6001B82")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E7CA64", Offset = "0x1E7CA64", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "FilterMembers", MemberParameters = new object[]
		{
			typeof(IList),
			typeof(Attribute[])
		}, ReturnType = typeof(ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		private static bool ShouldHideMember(MemberDescriptor member, Attribute attribute)
		{
			throw null;
		}

		// Token: 0x060018FA RID: 6394 RVA: 0x00007478 File Offset: 0x00005678
		[global::Cpp2ILInjected.Token(Token = "0x6001B83")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E84388", Offset = "0x1E84388", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EventDescriptorCollection), Member = "InternalSort", MemberParameters = new object[] { typeof(IComparer) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PropertyDescriptorCollection), Member = "InternalSort", MemberParameters = new object[] { typeof(IComparer) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = "Adapter", MemberParameters = new object[] { typeof(IList) }, ReturnType = typeof(ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static void SortDescriptorArray(IList infos)
		{
			throw null;
		}

		// Token: 0x060018FB RID: 6395 RVA: 0x0000747B File Offset: 0x0000567B
		[Conditional("DEBUG")]
		[global::Cpp2ILInjected.Token(Token = "0x6001B84")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E84454", Offset = "0x1E84454", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static void Trace(string message, params object[] args)
		{
			throw null;
		}

		// Token: 0x060018FC RID: 6396 RVA: 0x0000747E File Offset: 0x0000567E
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001B85")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E84458", Offset = "0x1E84458", Length = "0x28C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WeakHashtable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BooleanSwitch), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Guid), Member = "NewGuid", ReturnType = typeof(Guid))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		static TypeDescriptor()
		{
			throw null;
		}

		// Token: 0x04000F28 RID: 3880
		[global::Cpp2ILInjected.Token(Token = "0x4001355")]
		private static WeakHashtable _providerTable;

		// Token: 0x04000F29 RID: 3881
		[global::Cpp2ILInjected.Token(Token = "0x4001356")]
		private static Hashtable _providerTypeTable;

		// Token: 0x04000F2A RID: 3882
		[global::Cpp2ILInjected.Token(Token = "0x4001357")]
		private static Hashtable _defaultProviders;

		// Token: 0x04000F2B RID: 3883
		[global::Cpp2ILInjected.Token(Token = "0x4001358")]
		private static WeakHashtable _associationTable;

		// Token: 0x04000F2C RID: 3884
		[global::Cpp2ILInjected.Token(Token = "0x4001359")]
		private static int _metadataVersion;

		// Token: 0x04000F2D RID: 3885
		[global::Cpp2ILInjected.Token(Token = "0x400135A")]
		private static int _collisionIndex;

		// Token: 0x04000F2E RID: 3886
		[global::Cpp2ILInjected.Token(Token = "0x400135B")]
		private static BooleanSwitch TraceDescriptor;

		// Token: 0x04000F2F RID: 3887
		[global::Cpp2ILInjected.Token(Token = "0x400135C")]
		private const int PIPELINE_ATTRIBUTES = 0;

		// Token: 0x04000F30 RID: 3888
		[global::Cpp2ILInjected.Token(Token = "0x400135D")]
		private const int PIPELINE_PROPERTIES = 1;

		// Token: 0x04000F31 RID: 3889
		[global::Cpp2ILInjected.Token(Token = "0x400135E")]
		private const int PIPELINE_EVENTS = 2;

		// Token: 0x04000F32 RID: 3890
		[global::Cpp2ILInjected.Token(Token = "0x400135F")]
		private static readonly Guid[] _pipelineInitializeKeys;

		// Token: 0x04000F33 RID: 3891
		[global::Cpp2ILInjected.Token(Token = "0x4001360")]
		private static readonly Guid[] _pipelineMergeKeys;

		// Token: 0x04000F34 RID: 3892
		[global::Cpp2ILInjected.Token(Token = "0x4001361")]
		private static readonly Guid[] _pipelineFilterKeys;

		// Token: 0x04000F35 RID: 3893
		[global::Cpp2ILInjected.Token(Token = "0x4001362")]
		private static readonly Guid[] _pipelineAttributeFilterKeys;

		// Token: 0x04000F36 RID: 3894
		[global::Cpp2ILInjected.Token(Token = "0x4001363")]
		private static object _internalSyncObject;

		// Token: 0x04000F37 RID: 3895
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001364")]
		private static RefreshEventHandler Refreshed;

		// Token: 0x02000465 RID: 1125
		[global::Cpp2ILInjected.Token(Token = "0x20003F2")]
		private sealed class AttributeProvider : TypeDescriptionProvider
		{
			// Token: 0x06001F1F RID: 7967 RVA: 0x000085DC File Offset: 0x000067DC
			[global::Cpp2ILInjected.Token(Token = "0x6001B86")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E846E4", Offset = "0x1E846E4", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "AddAttributes", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(Attribute[])
			}, ReturnType = typeof(TypeDescriptionProvider))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "AddAttributes", MemberParameters = new object[]
			{
				typeof(object),
				typeof(Attribute[])
			}, ReturnType = typeof(TypeDescriptionProvider))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptionProvider), Member = ".ctor", MemberParameters = new object[] { typeof(TypeDescriptionProvider) }, ReturnType = typeof(void))]
			internal AttributeProvider(TypeDescriptionProvider existingProvider, params Attribute[] attrs)
			{
				throw null;
			}

			// Token: 0x06001F20 RID: 7968 RVA: 0x000085DF File Offset: 0x000067DF
			[global::Cpp2ILInjected.Token(Token = "0x6001B87")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E8470C", Offset = "0x1E8470C", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptionProvider), Member = "GetTypeDescriptor", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(object)
			}, ReturnType = typeof(ICustomTypeDescriptor))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomTypeDescriptor), Member = ".ctor", MemberParameters = new object[] { typeof(ICustomTypeDescriptor) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance)
			{
				throw null;
			}

			// Token: 0x040013B1 RID: 5041
			[global::Cpp2ILInjected.Token(Token = "0x4001365")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private Attribute[] _attrs;

			// Token: 0x020004BC RID: 1212
			[global::Cpp2ILInjected.Token(Token = "0x20003F3")]
			private class AttributeTypeDescriptor : CustomTypeDescriptor
			{
				// Token: 0x06002013 RID: 8211 RVA: 0x000087E6 File Offset: 0x000069E6
				[global::Cpp2ILInjected.Token(Token = "0x6001B88")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E8479C", Offset = "0x1E8479C", Length = "0x2C")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomTypeDescriptor), Member = ".ctor", MemberParameters = new object[] { typeof(ICustomTypeDescriptor) }, ReturnType = typeof(void))]
				internal AttributeTypeDescriptor(Attribute[] attrs, ICustomTypeDescriptor parent)
				{
					throw null;
				}

				// Token: 0x06002014 RID: 8212 RVA: 0x000087E9 File Offset: 0x000069E9
				[global::Cpp2ILInjected.Token(Token = "0x6001B89")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E847C8", Offset = "0x1E847C8", Length = "0x21C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomTypeDescriptor), Member = "GetAttributes", ReturnType = typeof(AttributeCollection))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AttributeCollection), Member = "get_Count", ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AttributeCollection), Member = "CopyTo", MemberParameters = new object[]
				{
					typeof(Array),
					typeof(int)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
				{
					typeof(Array),
					typeof(int),
					typeof(Array),
					typeof(int),
					typeof(int)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AttributeCollection), Member = ".ctor", MemberParameters = new object[] { typeof(Attribute[]) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
				public override AttributeCollection GetAttributes()
				{
					throw null;
				}

				// Token: 0x04001447 RID: 5191
				[global::Cpp2ILInjected.Token(Token = "0x4001366")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
				private Attribute[] _attributeArray;
			}
		}

		// Token: 0x02000466 RID: 1126
		[global::Cpp2ILInjected.Token(Token = "0x20003F4")]
		private sealed class ComNativeDescriptionProvider : TypeDescriptionProvider
		{
			// Token: 0x06001F21 RID: 7969 RVA: 0x000085E2 File Offset: 0x000067E2
			[global::Cpp2ILInjected.Token(Token = "0x6001B8A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E849E4", Offset = "0x1E849E4", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "set_ComNativeDescriptorHandler", MemberParameters = new object[] { typeof(IComNativeDescriptorHandler) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptionProvider), Member = ".ctor", ReturnType = typeof(void))]
			internal ComNativeDescriptionProvider(IComNativeDescriptorHandler handler)
			{
				throw null;
			}

			// Token: 0x17000764 RID: 1892
			// (get) Token: 0x06001F22 RID: 7970 RVA: 0x000085E5 File Offset: 0x000067E5
			// (set) Token: 0x06001F23 RID: 7971 RVA: 0x000085E8 File Offset: 0x000067E8
			[global::Cpp2ILInjected.Token(Token = "0x17000636")]
			internal IComNativeDescriptorHandler Handler
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001B8B")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E84A0C", Offset = "0x1E84A0C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x6001B8C")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E84A14", Offset = "0x1E84A14", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x06001F24 RID: 7972 RVA: 0x000085EB File Offset: 0x000067EB
			[global::Cpp2ILInjected.Token(Token = "0x6001B8D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E84A1C", Offset = "0x1E84A1C", Length = "0x14C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(Type)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
			public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance)
			{
				throw null;
			}

			// Token: 0x040013B2 RID: 5042
			[global::Cpp2ILInjected.Token(Token = "0x4001367")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private IComNativeDescriptorHandler _handler;

			// Token: 0x020004BD RID: 1213
			[global::Cpp2ILInjected.Token(Token = "0x20003F5")]
			private sealed class ComNativeTypeDescriptor : ICustomTypeDescriptor
			{
				// Token: 0x06002015 RID: 8213 RVA: 0x000087EC File Offset: 0x000069EC
				[global::Cpp2ILInjected.Token(Token = "0x6001B8E")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E84B68", Offset = "0x1E84B68", Length = "0x2C")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				internal ComNativeTypeDescriptor(IComNativeDescriptorHandler handler, object instance)
				{
					throw null;
				}

				// Token: 0x06002016 RID: 8214 RVA: 0x000087EF File Offset: 0x000069EF
				[global::Cpp2ILInjected.Token(Token = "0x6001B8F")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E84B94", Offset = "0x1E84B94", Length = "0x9C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
				private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes()
				{
					throw null;
				}

				// Token: 0x06002017 RID: 8215 RVA: 0x000087F2 File Offset: 0x000069F2
				[global::Cpp2ILInjected.Token(Token = "0x6001B90")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E84C30", Offset = "0x1E84C30", Length = "0xA0")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
				private string System.ComponentModel.ICustomTypeDescriptor.GetClassName()
				{
					throw null;
				}

				// Token: 0x06002018 RID: 8216 RVA: 0x000087F5 File Offset: 0x000069F5
				[global::Cpp2ILInjected.Token(Token = "0x6001B91")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E84CD0", Offset = "0x1E84CD0", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				private string System.ComponentModel.ICustomTypeDescriptor.GetComponentName()
				{
					throw null;
				}

				// Token: 0x06002019 RID: 8217 RVA: 0x000087F8 File Offset: 0x000069F8
				[global::Cpp2ILInjected.Token(Token = "0x6001B92")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E84CD8", Offset = "0x1E84CD8", Length = "0xA0")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
				private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter()
				{
					throw null;
				}

				// Token: 0x0600201A RID: 8218 RVA: 0x000087FB File Offset: 0x000069FB
				[global::Cpp2ILInjected.Token(Token = "0x6001B93")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E84D78", Offset = "0x1E84D78", Length = "0xA0")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
				private EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent()
				{
					throw null;
				}

				// Token: 0x0600201B RID: 8219 RVA: 0x000087FE File Offset: 0x000069FE
				[global::Cpp2ILInjected.Token(Token = "0x6001B94")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E84E18", Offset = "0x1E84E18", Length = "0xA0")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
				private PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty()
				{
					throw null;
				}

				// Token: 0x0600201C RID: 8220 RVA: 0x00008801 File Offset: 0x00006A01
				[global::Cpp2ILInjected.Token(Token = "0x6001B95")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E84EB8", Offset = "0x1E84EB8", Length = "0xB0")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
				private object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType)
				{
					throw null;
				}

				// Token: 0x0600201D RID: 8221 RVA: 0x00008804 File Offset: 0x00006A04
				[global::Cpp2ILInjected.Token(Token = "0x6001B96")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E84F68", Offset = "0x1E84F68", Length = "0xA0")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
				private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents()
				{
					throw null;
				}

				// Token: 0x0600201E RID: 8222 RVA: 0x00008807 File Offset: 0x00006A07
				[global::Cpp2ILInjected.Token(Token = "0x6001B97")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E85008", Offset = "0x1E85008", Length = "0xB0")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
				private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes)
				{
					throw null;
				}

				// Token: 0x0600201F RID: 8223 RVA: 0x0000880A File Offset: 0x00006A0A
				[global::Cpp2ILInjected.Token(Token = "0x6001B98")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E850B8", Offset = "0x1E850B8", Length = "0xA4")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
				private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties()
				{
					throw null;
				}

				// Token: 0x06002020 RID: 8224 RVA: 0x0000880D File Offset: 0x00006A0D
				[global::Cpp2ILInjected.Token(Token = "0x6001B99")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E8515C", Offset = "0x1E8515C", Length = "0xB0")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
				private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes)
				{
					throw null;
				}

				// Token: 0x06002021 RID: 8225 RVA: 0x00008810 File Offset: 0x00006A10
				[global::Cpp2ILInjected.Token(Token = "0x6001B9A")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E8520C", Offset = "0x1E8520C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd)
				{
					throw null;
				}

				// Token: 0x04001448 RID: 5192
				[global::Cpp2ILInjected.Token(Token = "0x4001368")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				private IComNativeDescriptorHandler _handler;

				// Token: 0x04001449 RID: 5193
				[global::Cpp2ILInjected.Token(Token = "0x4001369")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
				private object _instance;
			}
		}

		// Token: 0x02000467 RID: 1127
		[global::Cpp2ILInjected.Token(Token = "0x20003F6")]
		private sealed class AttributeFilterCacheItem
		{
			// Token: 0x06001F25 RID: 7973 RVA: 0x000085EE File Offset: 0x000067EE
			[global::Cpp2ILInjected.Token(Token = "0x6001B9B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E85214", Offset = "0x1E85214", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "PipelineAttributeFilter", MemberParameters = new object[]
			{
				typeof(int),
				typeof(ICollection),
				typeof(Attribute[]),
				typeof(object),
				typeof(IDictionary)
			}, ReturnType = typeof(ICollection))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			internal AttributeFilterCacheItem(Attribute[] filter, ICollection filteredMembers)
			{
				throw null;
			}

			// Token: 0x06001F26 RID: 7974 RVA: 0x000085F1 File Offset: 0x000067F1
			[global::Cpp2ILInjected.Token(Token = "0x6001B9C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E85240", Offset = "0x1E85240", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "PipelineAttributeFilter", MemberParameters = new object[]
			{
				typeof(int),
				typeof(ICollection),
				typeof(Attribute[]),
				typeof(object),
				typeof(IDictionary)
			}, ReturnType = typeof(ICollection))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			internal bool IsValid(Attribute[] filter)
			{
				throw null;
			}

			// Token: 0x040013B3 RID: 5043
			[global::Cpp2ILInjected.Token(Token = "0x400136A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private Attribute[] _filter;

			// Token: 0x040013B4 RID: 5044
			[global::Cpp2ILInjected.Token(Token = "0x400136B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			internal ICollection FilteredMembers;
		}

		// Token: 0x02000468 RID: 1128
		[global::Cpp2ILInjected.Token(Token = "0x20003F7")]
		private sealed class FilterCacheItem
		{
			// Token: 0x06001F27 RID: 7975 RVA: 0x000085F4 File Offset: 0x000067F4
			[global::Cpp2ILInjected.Token(Token = "0x6001B9D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E85294", Offset = "0x1E85294", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "PipelineFilter", MemberParameters = new object[]
			{
				typeof(int),
				typeof(ICollection),
				typeof(object),
				typeof(IDictionary)
			}, ReturnType = typeof(ICollection))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			internal FilterCacheItem(ITypeDescriptorFilterService filterService, ICollection filteredMembers)
			{
				throw null;
			}

			// Token: 0x06001F28 RID: 7976 RVA: 0x000085F7 File Offset: 0x000067F7
			[global::Cpp2ILInjected.Token(Token = "0x6001B9E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E852C0", Offset = "0x1E852C0", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "PipelineFilter", MemberParameters = new object[]
			{
				typeof(int),
				typeof(ICollection),
				typeof(object),
				typeof(IDictionary)
			}, ReturnType = typeof(ICollection))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			internal bool IsValid(ITypeDescriptorFilterService filterService)
			{
				throw null;
			}

			// Token: 0x040013B5 RID: 5045
			[global::Cpp2ILInjected.Token(Token = "0x400136C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private ITypeDescriptorFilterService _filterService;

			// Token: 0x040013B6 RID: 5046
			[global::Cpp2ILInjected.Token(Token = "0x400136D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			internal ICollection FilteredMembers;
		}

		// Token: 0x02000469 RID: 1129
		[global::Cpp2ILInjected.Token(Token = "0x20003F8")]
		private interface IUnimplemented
		{
		}

		// Token: 0x0200046A RID: 1130
		[global::Cpp2ILInjected.Token(Token = "0x20003F9")]
		private sealed class MemberDescriptorComparer : IComparer
		{
			// Token: 0x06001F29 RID: 7977 RVA: 0x000085FA File Offset: 0x000067FA
			[global::Cpp2ILInjected.Token(Token = "0x6001B9F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E852D0", Offset = "0x1E852D0", Length = "0x118")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(bool),
				typeof(CultureInfo)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public int Compare(object left, object right)
			{
				throw null;
			}

			// Token: 0x06001F2A RID: 7978 RVA: 0x000085FD File Offset: 0x000067FD
			[global::Cpp2ILInjected.Token(Token = "0x6001BA0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E853E8", Offset = "0x1E853E8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public MemberDescriptorComparer()
			{
				throw null;
			}

			// Token: 0x06001F2B RID: 7979 RVA: 0x00008600 File Offset: 0x00006800
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6001BA1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E853F0", Offset = "0x1E853F0", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static MemberDescriptorComparer()
			{
				throw null;
			}

			// Token: 0x040013B7 RID: 5047
			[global::Cpp2ILInjected.Token(Token = "0x400136E")]
			public static readonly TypeDescriptor.MemberDescriptorComparer Instance;
		}

		// Token: 0x0200046B RID: 1131
		[global::Cpp2ILInjected.Token(Token = "0x20003FA")]
		private sealed class MergedTypeDescriptor : ICustomTypeDescriptor
		{
			// Token: 0x06001F2C RID: 7980 RVA: 0x00008603 File Offset: 0x00006803
			[global::Cpp2ILInjected.Token(Token = "0x6001BA2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E8544C", Offset = "0x1E8544C", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetDescriptor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(bool)
			}, ReturnType = typeof(ICustomTypeDescriptor))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			internal MergedTypeDescriptor(ICustomTypeDescriptor primary, ICustomTypeDescriptor secondary)
			{
				throw null;
			}

			// Token: 0x06001F2D RID: 7981 RVA: 0x00008606 File Offset: 0x00006806
			[global::Cpp2ILInjected.Token(Token = "0x6001BA3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E85478", Offset = "0x1E85478", Length = "0x104")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes()
			{
				throw null;
			}

			// Token: 0x06001F2E RID: 7982 RVA: 0x00008609 File Offset: 0x00006809
			[global::Cpp2ILInjected.Token(Token = "0x6001BA4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E8557C", Offset = "0x1E8557C", Length = "0x10C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private string System.ComponentModel.ICustomTypeDescriptor.GetClassName()
			{
				throw null;
			}

			// Token: 0x06001F2F RID: 7983 RVA: 0x0000860C File Offset: 0x0000680C
			[global::Cpp2ILInjected.Token(Token = "0x6001BA5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E85688", Offset = "0x1E85688", Length = "0x10C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private string System.ComponentModel.ICustomTypeDescriptor.GetComponentName()
			{
				throw null;
			}

			// Token: 0x06001F30 RID: 7984 RVA: 0x0000860F File Offset: 0x0000680F
			[global::Cpp2ILInjected.Token(Token = "0x6001BA6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E85794", Offset = "0x1E85794", Length = "0x10C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter()
			{
				throw null;
			}

			// Token: 0x06001F31 RID: 7985 RVA: 0x00008612 File Offset: 0x00006812
			[global::Cpp2ILInjected.Token(Token = "0x6001BA7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E858A0", Offset = "0x1E858A0", Length = "0x10C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent()
			{
				throw null;
			}

			// Token: 0x06001F32 RID: 7986 RVA: 0x00008615 File Offset: 0x00006815
			[global::Cpp2ILInjected.Token(Token = "0x6001BA8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E859AC", Offset = "0x1E859AC", Length = "0x10C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty()
			{
				throw null;
			}

			// Token: 0x06001F33 RID: 7987 RVA: 0x00008618 File Offset: 0x00006818
			[global::Cpp2ILInjected.Token(Token = "0x6001BA9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E85AB8", Offset = "0x1E85AB8", Length = "0x1A4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(Type)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
			private object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType)
			{
				throw null;
			}

			// Token: 0x06001F34 RID: 7988 RVA: 0x0000861B File Offset: 0x0000681B
			[global::Cpp2ILInjected.Token(Token = "0x6001BAA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E85C5C", Offset = "0x1E85C5C", Length = "0x10C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents()
			{
				throw null;
			}

			// Token: 0x06001F35 RID: 7989 RVA: 0x0000861E File Offset: 0x0000681E
			[global::Cpp2ILInjected.Token(Token = "0x6001BAB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E85D68", Offset = "0x1E85D68", Length = "0x124")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes)
			{
				throw null;
			}

			// Token: 0x06001F36 RID: 7990 RVA: 0x00008621 File Offset: 0x00006821
			[global::Cpp2ILInjected.Token(Token = "0x6001BAC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E85E8C", Offset = "0x1E85E8C", Length = "0x10C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties()
			{
				throw null;
			}

			// Token: 0x06001F37 RID: 7991 RVA: 0x00008624 File Offset: 0x00006824
			[global::Cpp2ILInjected.Token(Token = "0x6001BAD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E85F98", Offset = "0x1E85F98", Length = "0x124")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes)
			{
				throw null;
			}

			// Token: 0x06001F38 RID: 7992 RVA: 0x00008627 File Offset: 0x00006827
			[global::Cpp2ILInjected.Token(Token = "0x6001BAE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E860BC", Offset = "0x1E860BC", Length = "0x124")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd)
			{
				throw null;
			}

			// Token: 0x040013B8 RID: 5048
			[global::Cpp2ILInjected.Token(Token = "0x400136F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private ICustomTypeDescriptor _primary;

			// Token: 0x040013B9 RID: 5049
			[global::Cpp2ILInjected.Token(Token = "0x4001370")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private ICustomTypeDescriptor _secondary;
		}

		// Token: 0x0200046C RID: 1132
		[global::Cpp2ILInjected.Token(Token = "0x20003FB")]
		private sealed class TypeDescriptionNode : TypeDescriptionProvider
		{
			// Token: 0x06001F39 RID: 7993 RVA: 0x0000862A File Offset: 0x0000682A
			[global::Cpp2ILInjected.Token(Token = "0x6001BAF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E861E0", Offset = "0x1E861E0", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "AddProvider", MemberParameters = new object[]
			{
				typeof(TypeDescriptionProvider),
				typeof(Type)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "AddProvider", MemberParameters = new object[]
			{
				typeof(TypeDescriptionProvider),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "NodeFor", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(bool)
			}, ReturnType = typeof(TypeDescriptor.TypeDescriptionNode))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "NodeFor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(bool)
			}, ReturnType = typeof(TypeDescriptor.TypeDescriptionNode))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptionProvider), Member = ".ctor", ReturnType = typeof(void))]
			internal TypeDescriptionNode(TypeDescriptionProvider provider)
			{
				throw null;
			}

			// Token: 0x06001F3A RID: 7994 RVA: 0x0000862D File Offset: 0x0000682D
			[global::Cpp2ILInjected.Token(Token = "0x6001BB0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E86208", Offset = "0x1E86208", Length = "0x170")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(Type)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
			public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args)
			{
				throw null;
			}

			// Token: 0x06001F3B RID: 7995 RVA: 0x00008630 File Offset: 0x00006830
			[global::Cpp2ILInjected.Token(Token = "0x6001BB1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E86378", Offset = "0x1E86378", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public override IDictionary GetCache(object instance)
			{
				throw null;
			}

			// Token: 0x06001F3C RID: 7996 RVA: 0x00008633 File Offset: 0x00006833
			[global::Cpp2ILInjected.Token(Token = "0x6001BB2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E863DC", Offset = "0x1E863DC", Length = "0xA8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			public override ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance)
			{
				throw null;
			}

			// Token: 0x06001F3D RID: 7997 RVA: 0x00008636 File Offset: 0x00006836
			[global::Cpp2ILInjected.Token(Token = "0x6001BB3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E8648C", Offset = "0x1E8648C", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			protected internal override IExtenderProvider[] GetExtenderProviders(object instance)
			{
				throw null;
			}

			// Token: 0x06001F3E RID: 7998 RVA: 0x00008639 File Offset: 0x00006839
			[global::Cpp2ILInjected.Token(Token = "0x6001BB4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E864F0", Offset = "0x1E864F0", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public override string GetFullComponentName(object component)
			{
				throw null;
			}

			// Token: 0x06001F3F RID: 7999 RVA: 0x0000863C File Offset: 0x0000683C
			[global::Cpp2ILInjected.Token(Token = "0x6001BB5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E86554", Offset = "0x1E86554", Length = "0xD0")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(Type)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			public override Type GetReflectionType(Type objectType, object instance)
			{
				throw null;
			}

			// Token: 0x06001F40 RID: 8000 RVA: 0x0000863F File Offset: 0x0000683F
			[global::Cpp2ILInjected.Token(Token = "0x6001BB6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E86624", Offset = "0x1E86624", Length = "0xC8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(Type)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			public override Type GetRuntimeType(Type objectType)
			{
				throw null;
			}

			// Token: 0x06001F41 RID: 8001 RVA: 0x00008642 File Offset: 0x00006842
			[global::Cpp2ILInjected.Token(Token = "0x6001BB7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E866EC", Offset = "0x1E866EC", Length = "0x140")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(Type)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
			public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance)
			{
				throw null;
			}

			// Token: 0x06001F42 RID: 8002 RVA: 0x00008645 File Offset: 0x00006845
			[global::Cpp2ILInjected.Token(Token = "0x6001BB8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E86838", Offset = "0x1E86838", Length = "0xC8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(Type)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			public override bool IsSupportedType(Type type)
			{
				throw null;
			}

			// Token: 0x040013BA RID: 5050
			[global::Cpp2ILInjected.Token(Token = "0x4001371")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			internal TypeDescriptor.TypeDescriptionNode Next;

			// Token: 0x040013BB RID: 5051
			[global::Cpp2ILInjected.Token(Token = "0x4001372")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			internal TypeDescriptionProvider Provider;

			// Token: 0x020004BE RID: 1214
			[global::Cpp2ILInjected.Token(Token = "0x20003FC")]
			private struct DefaultExtendedTypeDescriptor : ICustomTypeDescriptor
			{
				// Token: 0x06002022 RID: 8226 RVA: 0x00008813 File Offset: 0x00006A13
				[global::Cpp2ILInjected.Token(Token = "0x6001BB9")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E86484", Offset = "0x1E86484", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				internal DefaultExtendedTypeDescriptor(TypeDescriptor.TypeDescriptionNode node, object instance)
				{
					throw null;
				}

				// Token: 0x06002023 RID: 8227 RVA: 0x00008816 File Offset: 0x00006A16
				[global::Cpp2ILInjected.Token(Token = "0x6001BBA")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E86900", Offset = "0x1E86900", Length = "0x24C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
				{
					typeof(string),
					typeof(object[])
				}, ReturnType = typeof(string))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
				private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes()
				{
					throw null;
				}

				// Token: 0x06002024 RID: 8228 RVA: 0x00008819 File Offset: 0x00006A19
				[global::Cpp2ILInjected.Token(Token = "0x6001BBB")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E86B4C", Offset = "0x1E86B4C", Length = "0x1E4")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetExtendedClassName", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
				{
					typeof(string),
					typeof(object[])
				}, ReturnType = typeof(string))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
				private string System.ComponentModel.ICustomTypeDescriptor.GetClassName()
				{
					throw null;
				}

				// Token: 0x06002025 RID: 8229 RVA: 0x0000881C File Offset: 0x00006A1C
				[global::Cpp2ILInjected.Token(Token = "0x6001BBC")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E86D30", Offset = "0x1E86D30", Length = "0x1B8")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetExtendedComponentName", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
				{
					typeof(string),
					typeof(object[])
				}, ReturnType = typeof(string))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
				private string System.ComponentModel.ICustomTypeDescriptor.GetComponentName()
				{
					throw null;
				}

				// Token: 0x06002026 RID: 8230 RVA: 0x0000881F File Offset: 0x00006A1F
				[global::Cpp2ILInjected.Token(Token = "0x6001BBD")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E86EE8", Offset = "0x1E86EE8", Length = "0x21C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetExtendedConverter", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(TypeConverter))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
				{
					typeof(string),
					typeof(object[])
				}, ReturnType = typeof(string))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
				private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter()
				{
					throw null;
				}

				// Token: 0x06002027 RID: 8231 RVA: 0x00008822 File Offset: 0x00006A22
				[global::Cpp2ILInjected.Token(Token = "0x6001BBE")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E87104", Offset = "0x1E87104", Length = "0x1B8")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetExtendedDefaultEvent", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(EventDescriptor))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
				{
					typeof(string),
					typeof(object[])
				}, ReturnType = typeof(string))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
				private EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent()
				{
					throw null;
				}

				// Token: 0x06002028 RID: 8232 RVA: 0x00008825 File Offset: 0x00006A25
				[global::Cpp2ILInjected.Token(Token = "0x6001BBF")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E872BC", Offset = "0x1E872BC", Length = "0x1B8")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetExtendedDefaultProperty", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(PropertyDescriptor))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
				{
					typeof(string),
					typeof(object[])
				}, ReturnType = typeof(string))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
				private PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty()
				{
					throw null;
				}

				// Token: 0x06002029 RID: 8233 RVA: 0x00008828 File Offset: 0x00006A28
				[global::Cpp2ILInjected.Token(Token = "0x6001BC0")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E87474", Offset = "0x1E87474", Length = "0x250")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
				{
					typeof(Type),
					typeof(Type)
				}, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetExtendedEditor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(Type)
				}, ReturnType = typeof(object))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
				{
					typeof(string),
					typeof(object[])
				}, ReturnType = typeof(string))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
				private object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType)
				{
					throw null;
				}

				// Token: 0x0600202A RID: 8234 RVA: 0x0000882B File Offset: 0x00006A2B
				[global::Cpp2ILInjected.Token(Token = "0x6001BC1")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E876C4", Offset = "0x1E876C4", Length = "0x250")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
				{
					typeof(string),
					typeof(object[])
				}, ReturnType = typeof(string))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
				private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents()
				{
					throw null;
				}

				// Token: 0x0600202B RID: 8235 RVA: 0x0000882E File Offset: 0x00006A2E
				[global::Cpp2ILInjected.Token(Token = "0x6001BC2")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E87914", Offset = "0x1E87914", Length = "0x260")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
				{
					typeof(string),
					typeof(object[])
				}, ReturnType = typeof(string))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
				private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes)
				{
					throw null;
				}

				// Token: 0x0600202C RID: 8236 RVA: 0x00008831 File Offset: 0x00006A31
				[global::Cpp2ILInjected.Token(Token = "0x6001BC3")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E87B74", Offset = "0x1E87B74", Length = "0x21C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetExtendedProperties", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(PropertyDescriptorCollection))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
				{
					typeof(string),
					typeof(object[])
				}, ReturnType = typeof(string))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
				private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties()
				{
					throw null;
				}

				// Token: 0x0600202D RID: 8237 RVA: 0x00008834 File Offset: 0x00006A34
				[global::Cpp2ILInjected.Token(Token = "0x6001BC4")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E87D90", Offset = "0x1E87D90", Length = "0x230")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetExtendedProperties", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(PropertyDescriptorCollection))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
				{
					typeof(string),
					typeof(object[])
				}, ReturnType = typeof(string))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
				private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes)
				{
					throw null;
				}

				// Token: 0x0600202E RID: 8238 RVA: 0x00008837 File Offset: 0x00006A37
				[global::Cpp2ILInjected.Token(Token = "0x6001BC5")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E87FC0", Offset = "0x1E87FC0", Length = "0x1DC")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetExtendedPropertyOwner", MemberParameters = new object[]
				{
					typeof(object),
					typeof(PropertyDescriptor)
				}, ReturnType = typeof(object))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
				{
					typeof(string),
					typeof(object[])
				}, ReturnType = typeof(string))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
				private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd)
				{
					throw null;
				}

				// Token: 0x0400144A RID: 5194
				[global::Cpp2ILInjected.Token(Token = "0x4001373")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
				private TypeDescriptor.TypeDescriptionNode _node;

				// Token: 0x0400144B RID: 5195
				[global::Cpp2ILInjected.Token(Token = "0x4001374")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
				private object _instance;
			}

			// Token: 0x020004BF RID: 1215
			[global::Cpp2ILInjected.Token(Token = "0x20003FD")]
			private struct DefaultTypeDescriptor : ICustomTypeDescriptor
			{
				// Token: 0x0600202F RID: 8239 RVA: 0x0000883A File Offset: 0x00006A3A
				[global::Cpp2ILInjected.Token(Token = "0x6001BC6")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E8682C", Offset = "0x1E8682C", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				internal DefaultTypeDescriptor(TypeDescriptor.TypeDescriptionNode node, Type objectType, object instance)
				{
					throw null;
				}

				// Token: 0x06002030 RID: 8240 RVA: 0x0000883D File Offset: 0x00006A3D
				[global::Cpp2ILInjected.Token(Token = "0x6001BC7")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E8819C", Offset = "0x1E8819C", Length = "0x218")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetAttributes", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(AttributeCollection))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
				{
					typeof(string),
					typeof(object[])
				}, ReturnType = typeof(string))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
				private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes()
				{
					throw null;
				}

				// Token: 0x06002031 RID: 8241 RVA: 0x00008840 File Offset: 0x00006A40
				[global::Cpp2ILInjected.Token(Token = "0x6001BC8")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E883B4", Offset = "0x1E883B4", Length = "0x1DC")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetClassName", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(string))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
				{
					typeof(string),
					typeof(object[])
				}, ReturnType = typeof(string))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
				private string System.ComponentModel.ICustomTypeDescriptor.GetClassName()
				{
					throw null;
				}

				// Token: 0x06002032 RID: 8242 RVA: 0x00008843 File Offset: 0x00006A43
				[global::Cpp2ILInjected.Token(Token = "0x6001BC9")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E88590", Offset = "0x1E88590", Length = "0x1B8")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetComponentName", MemberParameters = new object[]
				{
					typeof(Type),
					typeof(object)
				}, ReturnType = typeof(string))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
				{
					typeof(string),
					typeof(object[])
				}, ReturnType = typeof(string))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
				private string System.ComponentModel.ICustomTypeDescriptor.GetComponentName()
				{
					throw null;
				}

				// Token: 0x06002033 RID: 8243 RVA: 0x00008846 File Offset: 0x00006A46
				[global::Cpp2ILInjected.Token(Token = "0x6001BCA")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E88748", Offset = "0x1E88748", Length = "0x21C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetConverter", MemberParameters = new object[]
				{
					typeof(Type),
					typeof(object)
				}, ReturnType = typeof(TypeConverter))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
				{
					typeof(string),
					typeof(object[])
				}, ReturnType = typeof(string))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
				private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter()
				{
					throw null;
				}

				// Token: 0x06002034 RID: 8244 RVA: 0x00008849 File Offset: 0x00006A49
				[global::Cpp2ILInjected.Token(Token = "0x6001BCB")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E88964", Offset = "0x1E88964", Length = "0x1B8")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetDefaultEvent", MemberParameters = new object[]
				{
					typeof(Type),
					typeof(object)
				}, ReturnType = typeof(EventDescriptor))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
				{
					typeof(string),
					typeof(object[])
				}, ReturnType = typeof(string))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
				private EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent()
				{
					throw null;
				}

				// Token: 0x06002035 RID: 8245 RVA: 0x0000884C File Offset: 0x00006A4C
				[global::Cpp2ILInjected.Token(Token = "0x6001BCC")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E88B1C", Offset = "0x1E88B1C", Length = "0x1B8")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetDefaultProperty", MemberParameters = new object[]
				{
					typeof(Type),
					typeof(object)
				}, ReturnType = typeof(PropertyDescriptor))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
				{
					typeof(string),
					typeof(object[])
				}, ReturnType = typeof(string))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
				private PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty()
				{
					throw null;
				}

				// Token: 0x06002036 RID: 8246 RVA: 0x0000884F File Offset: 0x00006A4F
				[global::Cpp2ILInjected.Token(Token = "0x6001BCD")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E88CD4", Offset = "0x1E88CD4", Length = "0x250")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
				{
					typeof(Type),
					typeof(Type)
				}, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetEditor", MemberParameters = new object[]
				{
					typeof(Type),
					typeof(object),
					typeof(Type)
				}, ReturnType = typeof(object))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
				{
					typeof(string),
					typeof(object[])
				}, ReturnType = typeof(string))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
				private object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType)
				{
					throw null;
				}

				// Token: 0x06002037 RID: 8247 RVA: 0x00008852 File Offset: 0x00006A52
				[global::Cpp2ILInjected.Token(Token = "0x6001BCE")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E88F24", Offset = "0x1E88F24", Length = "0x21C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetEvents", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(EventDescriptorCollection))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
				{
					typeof(string),
					typeof(object[])
				}, ReturnType = typeof(string))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
				private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents()
				{
					throw null;
				}

				// Token: 0x06002038 RID: 8248 RVA: 0x00008855 File Offset: 0x00006A55
				[global::Cpp2ILInjected.Token(Token = "0x6001BCF")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E89140", Offset = "0x1E89140", Length = "0x230")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetEvents", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(EventDescriptorCollection))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
				{
					typeof(string),
					typeof(object[])
				}, ReturnType = typeof(string))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
				private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes)
				{
					throw null;
				}

				// Token: 0x06002039 RID: 8249 RVA: 0x00008858 File Offset: 0x00006A58
				[global::Cpp2ILInjected.Token(Token = "0x6001BD0")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E89370", Offset = "0x1E89370", Length = "0x21C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetProperties", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(PropertyDescriptorCollection))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
				{
					typeof(string),
					typeof(object[])
				}, ReturnType = typeof(string))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
				private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties()
				{
					throw null;
				}

				// Token: 0x0600203A RID: 8250 RVA: 0x0000885B File Offset: 0x00006A5B
				[global::Cpp2ILInjected.Token(Token = "0x6001BD1")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E8958C", Offset = "0x1E8958C", Length = "0x230")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetProperties", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(PropertyDescriptorCollection))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
				{
					typeof(string),
					typeof(object[])
				}, ReturnType = typeof(string))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
				private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes)
				{
					throw null;
				}

				// Token: 0x0600203B RID: 8251 RVA: 0x0000885E File Offset: 0x00006A5E
				[global::Cpp2ILInjected.Token(Token = "0x6001BD2")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E897BC", Offset = "0x1E897BC", Length = "0x1DC")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetPropertyOwner", MemberParameters = new object[]
				{
					typeof(Type),
					typeof(object),
					typeof(PropertyDescriptor)
				}, ReturnType = typeof(object))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
				{
					typeof(string),
					typeof(object[])
				}, ReturnType = typeof(string))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
				private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd)
				{
					throw null;
				}

				// Token: 0x0400144C RID: 5196
				[global::Cpp2ILInjected.Token(Token = "0x4001375")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
				private TypeDescriptor.TypeDescriptionNode _node;

				// Token: 0x0400144D RID: 5197
				[global::Cpp2ILInjected.Token(Token = "0x4001376")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
				private Type _objectType;

				// Token: 0x0400144E RID: 5198
				[global::Cpp2ILInjected.Token(Token = "0x4001377")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				private object _instance;
			}
		}

		// Token: 0x0200046D RID: 1133
		[TypeDescriptionProvider("System.Windows.Forms.ComponentModel.Com2Interop.ComNativeDescriptor, System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
		[global::Cpp2ILInjected.Token(Token = "0x20003FE")]
		private sealed class TypeDescriptorComObject
		{
			// Token: 0x06001F43 RID: 8003 RVA: 0x00008648 File Offset: 0x00006848
			[global::Cpp2ILInjected.Token(Token = "0x6001BD3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E89998", Offset = "0x1E89998", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public TypeDescriptorComObject()
			{
				throw null;
			}
		}

		// Token: 0x0200046E RID: 1134
		[global::Cpp2ILInjected.Token(Token = "0x20003FF")]
		private sealed class TypeDescriptorInterface
		{
			// Token: 0x06001F44 RID: 8004 RVA: 0x0000864B File Offset: 0x0000684B
			[global::Cpp2ILInjected.Token(Token = "0x6001BD4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E899A0", Offset = "0x1E899A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public TypeDescriptorInterface()
			{
				throw null;
			}
		}
	}
}
