using System;
using System.Collections;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Resources
{
	// Token: 0x020003FB RID: 1019
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20004B9")]
	[global::System.Serializable]
	public class ResourceSet : global::System.IDisposable, global::System.Collections.IEnumerable
	{
		// Token: 0x060020B5 RID: 8373 RVA: 0x0001A0AB File Offset: 0x000182AB
		[global::Cpp2ILInjected.Token(Token = "0x600234D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7FD6C", Offset = "0x1B7FD6C", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected ResourceSet()
		{
			throw null;
		}

		// Token: 0x060020B6 RID: 8374 RVA: 0x0001A0AE File Offset: 0x000182AE
		[global::Cpp2ILInjected.Token(Token = "0x600234E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B76120", Offset = "0x1B76120", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal ResourceSet(bool junk)
		{
			throw null;
		}

		// Token: 0x060020B7 RID: 8375 RVA: 0x0001A0B1 File Offset: 0x000182B1
		[global::Cpp2ILInjected.Token(Token = "0x600234F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7FD88", Offset = "0x1B7FD88", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void CommonInit()
		{
			throw null;
		}

		// Token: 0x060020B8 RID: 8376 RVA: 0x0001A0B4 File Offset: 0x000182B4
		[global::Cpp2ILInjected.Token(Token = "0x6002350")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7647C", Offset = "0x1B7647C", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeResourceSet), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x060020B9 RID: 8377 RVA: 0x0001A0B7 File Offset: 0x000182B7
		[global::Cpp2ILInjected.Token(Token = "0x6002351")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7C4A0", Offset = "0x1B7C4A0", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x060020BA RID: 8378 RVA: 0x0001A0BA File Offset: 0x000182BA
		[global::System.Runtime.InteropServices.ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6002352")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7FDE0", Offset = "0x1B7FDE0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual global::System.Collections.IDictionaryEnumerator GetEnumerator()
		{
			throw null;
		}

		// Token: 0x060020BB RID: 8379 RVA: 0x0001A0BD File Offset: 0x000182BD
		[global::Cpp2ILInjected.Token(Token = "0x6002353")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7FE60", Offset = "0x1B7FE60", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourceSet), Member = "GetEnumeratorHelper", ReturnType = typeof(global::System.Collections.IDictionaryEnumerator))]
		private global::System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x060020BC RID: 8380 RVA: 0x0001A0C0 File Offset: 0x000182C0
		[global::Cpp2ILInjected.Token(Token = "0x6002354")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7FDE4", Offset = "0x1B7FDE4", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourceSet), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(global::System.Collections.IEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ObjectDisposedException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private global::System.Collections.IDictionaryEnumerator GetEnumeratorHelper()
		{
			throw null;
		}

		// Token: 0x060020BD RID: 8381 RVA: 0x0001A0C3 File Offset: 0x000182C3
		[global::Cpp2ILInjected.Token(Token = "0x6002355")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7FE64", Offset = "0x1B7FE64", Length = "0x14C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourceSet), Member = "GetObjectInternal", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public virtual string GetString(string name)
		{
			throw null;
		}

		// Token: 0x060020BE RID: 8382 RVA: 0x0001A0C6 File Offset: 0x000182C6
		[global::Cpp2ILInjected.Token(Token = "0x6002356")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B80078", Offset = "0x1B80078", Length = "0x1E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourceSet), Member = "GetObjectInternal", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourceSet), Member = "GetCaseInsensitiveObjectInternal", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
		public virtual string GetString(string name, bool ignoreCase)
		{
			throw null;
		}

		// Token: 0x060020BF RID: 8383 RVA: 0x0001A0C9 File Offset: 0x000182C9
		[global::Cpp2ILInjected.Token(Token = "0x6002357")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8051C", Offset = "0x1B8051C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourceSet), Member = "GetObjectInternal", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(object))]
		public virtual object GetObject(string name)
		{
			throw null;
		}

		// Token: 0x060020C0 RID: 8384 RVA: 0x0001A0CC File Offset: 0x000182CC
		[global::Cpp2ILInjected.Token(Token = "0x6002358")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B80520", Offset = "0x1B80520", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourceSet), Member = "GetObjectInternal", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourceSet), Member = "GetCaseInsensitiveObjectInternal", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(object))]
		public virtual object GetObject(string name, bool ignoreCase)
		{
			throw null;
		}

		// Token: 0x060020C1 RID: 8385 RVA: 0x0001A0CF File Offset: 0x000182CF
		[global::Cpp2ILInjected.Token(Token = "0x6002359")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7FFB0", Offset = "0x1B7FFB0", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourceSet), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourceSet), Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourceSet), Member = "GetObject", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourceSet), Member = "GetObject", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ObjectDisposedException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private object GetObjectInternal(string name)
		{
			throw null;
		}

		// Token: 0x060020C2 RID: 8386 RVA: 0x0001A0D2 File Offset: 0x000182D2
		[global::Cpp2ILInjected.Token(Token = "0x600235A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B80260", Offset = "0x1B80260", Length = "0x2BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourceSet), Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourceSet), Member = "GetObject", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Hashtable), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Collections.IEqualityComparer) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ObjectDisposedException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		private object GetCaseInsensitiveObjectInternal(string name)
		{
			throw null;
		}

		// Token: 0x04001037 RID: 4151
		[global::Cpp2ILInjected.Token(Token = "0x4001351")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		[global::System.NonSerialized]
		protected IResourceReader Reader;

		// Token: 0x04001038 RID: 4152
		[global::Cpp2ILInjected.Token(Token = "0x4001352")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		protected global::System.Collections.Hashtable Table;

		// Token: 0x04001039 RID: 4153
		[global::Cpp2ILInjected.Token(Token = "0x4001353")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private global::System.Collections.Hashtable _caseInsensitiveTable;
	}
}
