using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x0200005C RID: 92
	[global::System.Diagnostics.DebuggerDisplay("Count = {InnerExceptionCount}")]
	[global::Cpp2ILInjected.Token(Token = "0x2000081")]
	[global::System.Serializable]
	public class AggregateException : global::System.Exception
	{
		// Token: 0x06000322 RID: 802 RVA: 0x00014E97 File Offset: 0x00013097
		[global::Cpp2ILInjected.Token(Token = "0x60003B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB4384", Offset = "0x1BB4384", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.ObjectModel.ReadOnlyCollection<object>), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Collections.Generic.IList<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public AggregateException()
		{
			throw null;
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00014E9A File Offset: 0x0001309A
		[global::Cpp2ILInjected.Token(Token = "0x60003B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB4498", Offset = "0x1BB4498", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.CancellationTokenSource), Member = "ExecuteCallbackHandlers", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public AggregateException(global::System.Collections.Generic.IEnumerable<global::System.Exception> innerExceptions)
		{
			throw null;
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00014E9D File Offset: 0x0001309D
		[global::Cpp2ILInjected.Token(Token = "0x60003B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB45AC", Offset = "0x1BB45AC", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "GetExceptions", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(global::System.AggregateException))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.TaskExceptionHolder), Member = "CreateExceptionObject", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(global::System.Exception)
		}, ReturnType = typeof(global::System.AggregateException))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.AsyncMethodBuilderCore), Member = "ThrowAsync", MemberParameters = new object[]
		{
			typeof(global::System.Exception),
			typeof(global::System.Threading.SynchronizationContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.AggregateException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Collections.Generic.IList<global::System.Exception>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public AggregateException(params global::System.Exception[] innerExceptions)
		{
			throw null;
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00014EA0 File Offset: 0x000130A0
		[global::Cpp2ILInjected.Token(Token = "0x60003B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB44F0", Offset = "0x1BB44F0", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Collections.Generic.IEnumerable<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.AggregateException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Collections.Generic.IList<global::System.Exception>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public AggregateException(string message, global::System.Collections.Generic.IEnumerable<global::System.Exception> innerExceptions)
		{
			throw null;
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00014EA3 File Offset: 0x000130A3
		[global::Cpp2ILInjected.Token(Token = "0x60003B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB4604", Offset = "0x1BB4604", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public AggregateException(string message, params global::System.Exception[] innerExceptions)
		{
			throw null;
		}

		// Token: 0x06000327 RID: 807 RVA: 0x00014EA6 File Offset: 0x000130A6
		[global::Cpp2ILInjected.Token(Token = "0x60003B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB4608", Offset = "0x1BB4608", Length = "0x3A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.AggregateException), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Exception[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.AggregateException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Collections.Generic.IEnumerable<global::System.Exception>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.AggregateException), Member = "Flatten", ReturnType = typeof(global::System.AggregateException))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.ObjectModel.ReadOnlyCollection<object>), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Collections.Generic.IList<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		private AggregateException(string message, global::System.Collections.Generic.IList<global::System.Exception> innerExceptions)
		{
			throw null;
		}

		// Token: 0x06000328 RID: 808 RVA: 0x00014EA9 File Offset: 0x000130A9
		[global::Cpp2ILInjected.Token(Token = "0x60003B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB49D0", Offset = "0x1BB49D0", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.TaskExceptionHolder), Member = "CreateExceptionObject", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(global::System.Exception)
		}, ReturnType = typeof(global::System.AggregateException))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal AggregateException(global::System.Collections.Generic.IEnumerable<global::System.Runtime.ExceptionServices.ExceptionDispatchInfo> innerExceptionInfos)
		{
			throw null;
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00014EAC File Offset: 0x000130AC
		[global::Cpp2ILInjected.Token(Token = "0x60003BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB4A28", Offset = "0x1BB4A28", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.TaskExceptionHolder), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Collections.Generic.IEnumerable<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal AggregateException(string message, global::System.Collections.Generic.IEnumerable<global::System.Runtime.ExceptionServices.ExceptionDispatchInfo> innerExceptionInfos)
		{
			throw null;
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00014EAF File Offset: 0x000130AF
		[global::Cpp2ILInjected.Token(Token = "0x60003BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB4AE4", Offset = "0x1BB4AE4", Length = "0x410")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.ObjectModel.ReadOnlyCollection<object>), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Collections.Generic.IList<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
		private AggregateException(string message, global::System.Collections.Generic.IList<global::System.Runtime.ExceptionServices.ExceptionDispatchInfo> innerExceptionInfos)
		{
			throw null;
		}

		// Token: 0x0600032B RID: 811 RVA: 0x00014EB2 File Offset: 0x000130B2
		[global::Cpp2ILInjected.Token(Token = "0x60003BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB4EF4", Offset = "0x1BB4EF4", Length = "0x1D8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.ObjectModel.ReadOnlyCollection<object>), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Collections.Generic.IList<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		protected AggregateException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00014EB5 File Offset: 0x000130B5
		[global::Cpp2ILInjected.Token(Token = "0x60003BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB50CC", Offset = "0x1BB50CC", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.ObjectModel.ReadOnlyCollection<object>), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.ObjectModel.ReadOnlyCollection<object>), Member = "CopyTo", MemberParameters = new object[]
		{
			typeof(object[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600032D RID: 813 RVA: 0x00014EB8 File Offset: 0x000130B8
		[global::Cpp2ILInjected.Token(Token = "0x17000056")]
		public global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Exception> InnerExceptions
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003BE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BB5220", Offset = "0x1BB5220", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00014EBB File Offset: 0x000130BB
		[global::Cpp2ILInjected.Token(Token = "0x60003BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB5228", Offset = "0x1BB5228", Length = "0x39C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpWebRequest", Member = "FlattenException", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.AggregateException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Collections.Generic.IList<global::System.Exception>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public global::System.AggregateException Flatten()
		{
			throw null;
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600032F RID: 815 RVA: 0x00014EBE File Offset: 0x000130BE
		[global::Cpp2ILInjected.Token(Token = "0x17000057")]
		public override string Message
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003C0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BB55C4", Offset = "0x1BB55C4", Length = "0x180")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.ObjectModel.ReadOnlyCollection<object>), Member = "get_Count", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilderCache), Member = "Acquire", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.Text.StringBuilder))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = "get_Message", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Text.StringBuilder))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(global::System.Text.StringBuilder))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.ObjectModel.ReadOnlyCollection<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "set_Length", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilderCache), Member = "GetStringAndRelease", MemberParameters = new object[] { typeof(global::System.Text.StringBuilder) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00014EC1 File Offset: 0x000130C1
		[global::Cpp2ILInjected.Token(Token = "0x60003C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB5744", Offset = "0x1BB5744", Length = "0x20C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.ObjectModel.ReadOnlyCollection<object>), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "AppendLine", ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "AppendFormat", MemberParameters = new object[]
		{
			typeof(global::System.IFormatProvider),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.ObjectModel.ReadOnlyCollection<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x040000F9 RID: 249
		[global::Cpp2ILInjected.Token(Token = "0x40001DA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Exception> m_innerExceptions;
	}
}
