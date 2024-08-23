using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x02000140 RID: 320
	[global::System.Runtime.InteropServices.ClassInterface(global::System.Runtime.InteropServices.ClassInterfaceType.AutoDual)]
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000187")]
	[global::System.Serializable]
	public class Object
	{
		// Token: 0x06000E48 RID: 3656 RVA: 0x00016DB7 File Offset: 0x00014FB7
		[global::Cpp2ILInjected.Token(Token = "0x6000F33")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C82224", Offset = "0x1C82224", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.ConstructorInfo), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.EventInfo), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.FieldInfo), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.MemberInfo), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.MethodBase), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.MethodInfo), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Module), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.PropertyInfo), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Assembly), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JValue", Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		public virtual bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06000E49 RID: 3657 RVA: 0x00016DBA File Offset: 0x00014FBA
		[global::Cpp2ILInjected.Token(Token = "0x6000F34")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C82230", Offset = "0x1C82230", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ContextAwareResult", Member = "FinishPostingAsyncOp", MemberParameters = new object[] { "System.Net.CallbackClosure&" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.CallbackClosure", Member = "IsCompatible", MemberParameters = new object[] { typeof(global::System.AsyncCallback) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.UdpReceiveResult", Member = "Equals", MemberParameters = new object[] { "System.Net.Sockets.UdpReceiveResult" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectPropertyDescriptor", Member = "ExtenderCanResetValue", MemberParameters = new object[]
		{
			"System.ComponentModel.IExtenderProvider",
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectPropertyDescriptor", Member = "ExtenderShouldSerializeValue", MemberParameters = new object[]
		{
			"System.ComponentModel.IExtenderProvider",
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectPropertyDescriptor", Member = "CanResetValue", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectPropertyDescriptor", Member = "ShouldSerializeValue", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.DictionaryWrapper`2", Member = "Remove", MemberParameters = new object[] { "System.Collections.Generic.KeyValuePair`2<TKey, TValue>" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JEnumerable`1", Member = "Equals", MemberParameters = new object[] { "Newtonsoft.Json.Linq.JEnumerable`1<T>" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JEnumerable`1", Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static bool Equals(object objA, object objB)
		{
			throw null;
		}

		// Token: 0x06000E4A RID: 3658 RVA: 0x00016DBD File Offset: 0x00014FBD
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.MayFail)]
		[global::Cpp2ILInjected.Token(Token = "0x6000F35")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C75174", Offset = "0x1C75174", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5291)]
		public Object()
		{
			throw null;
		}

		// Token: 0x06000E4B RID: 3659 RVA: 0x00016DC0 File Offset: 0x00014FC0
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
		[global::Cpp2ILInjected.Token(Token = "0x6000F36")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8225C", Offset = "0x1C8225C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 195)]
		protected virtual void Finalize()
		{
			throw null;
		}

		// Token: 0x06000E4C RID: 3660 RVA: 0x00016DC3 File Offset: 0x00014FC3
		[global::Cpp2ILInjected.Token(Token = "0x6000F37")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C82260", Offset = "0x1C82260", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.CodeAccessPermission), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.PermissionSet), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.ConstructorInfo), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.EventInfo), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.FieldInfo), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.MemberInfo), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.MethodBase), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.MethodInfo), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Module), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.PropertyInfo), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Assembly), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimeAssembly), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.BindingSource", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Object", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06000E4D RID: 3661
		[global::Cpp2ILInjected.Token(Token = "0x6000F38")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C758B8", Offset = "0x1C758B8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 528)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public extern global::System.Type GetType();

		// Token: 0x06000E4E RID: 3662
		[global::Cpp2ILInjected.Token(Token = "0x6000F39")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7CE08", Offset = "0x1C7CE08", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 30)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		protected extern object MemberwiseClone();

		// Token: 0x06000E4F RID: 3663 RVA: 0x00016DC6 File Offset: 0x00014FC6
		[global::Cpp2ILInjected.Token(Token = "0x6000F3A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C82268", Offset = "0x1C82268", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GraphicsResource", Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.X509Certificates.X509Certificate), Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Assembly), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.AssemblyName), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy", Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Events.UnityEventBase", Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.GUIContent", Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual string ToString()
		{
			throw null;
		}

		// Token: 0x06000E50 RID: 3664
		[global::Cpp2ILInjected.Token(Token = "0x6000F3B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C82264", Offset = "0x1C82264", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "GetHashCode", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern int InternalGetHashCode(object o);

		// Token: 0x06000E51 RID: 3665 RVA: 0x00016DC9 File Offset: 0x00014FC9
		[global::Cpp2ILInjected.Token(Token = "0x6000F3C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C82280", Offset = "0x1C82280", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void FieldGetter(string typeName, string fieldName, ref object val)
		{
			throw null;
		}

		// Token: 0x06000E52 RID: 3666 RVA: 0x00016DCC File Offset: 0x00014FCC
		[global::Cpp2ILInjected.Token(Token = "0x6000F3D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C82284", Offset = "0x1C82284", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void FieldSetter(string typeName, string fieldName, object val)
		{
			throw null;
		}
	}
}
