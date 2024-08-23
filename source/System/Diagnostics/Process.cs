using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace System.Diagnostics
{
	// Token: 0x0200007E RID: 126
	[DefaultEvent("Exited")]
	[MonitoringDescription("Provides access to local and remote processes, enabling starting and stopping of local processes.")]
	[DefaultProperty("StartInfo")]
	[global::Cpp2ILInjected.Token(Token = "0x20000D6")]
	public class Process : Component
	{
		// Token: 0x0600043C RID: 1084 RVA: 0x00003A4F File Offset: 0x00001C4F
		[global::Cpp2ILInjected.Token(Token = "0x60004DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC7794", Offset = "0x1EC7794", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.OS.OSX.Clipboard", Member = "GetClipboard", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.OS.OSX.Clipboard", Member = "SetClipboard", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.OS.Linux.Clipboard", Member = "GetClipboard", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.OS.Linux.Clipboard", Member = "ClearClipboard", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.OS.Linux.Clipboard", Member = "SetClipboard", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "Start", MemberParameters = new object[] { typeof(ProcessStartInfo) }, ReturnType = typeof(Process))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public Process()
		{
			throw null;
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x00003A52 File Offset: 0x00001C52
		[global::Cpp2ILInjected.Token(Token = "0x60004DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC781C", Offset = "0x1EC781C", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "GetCurrentProcess", ReturnType = typeof(Process))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private Process(string machineName, bool isRemoteMachine, int processId, ProcessInfo processInfo)
		{
			throw null;
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x0600043E RID: 1086 RVA: 0x00003A55 File Offset: 0x00001C55
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[MonitoringDescription("Indicates if the process component is associated with a real process.")]
		[Browsable(false)]
		[global::Cpp2ILInjected.Token(Token = "0x170000E1")]
		private bool Associated
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004DE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EC78B8", Offset = "0x1EC78B8", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x0600043F RID: 1087 RVA: 0x00003A58 File Offset: 0x00001C58
		[Browsable(false)]
		[MonitoringDescription("Indicates if the associated process has been terminated.")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[global::Cpp2ILInjected.Token(Token = "0x170000E2")]
		public bool HasExited
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004DF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EC78D8", Offset = "0x1EC78D8", Length = "0x338")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "EnsureState", MemberParameters = new object[] { typeof(Process.State) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = "EnsureState", MemberParameters = new object[] { typeof(Process.State) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = "GetProcessHandle", MemberParameters = new object[]
			{
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(SafeProcessHandle))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NativeMethods), Member = "GetExitCodeProcess", MemberParameters = new object[]
			{
				typeof(SafeProcessHandle),
				typeof(ref int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "Close", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = "RaiseOnExited", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ProcessWaitHandle), Member = ".ctor", MemberParameters = new object[] { typeof(SafeProcessHandle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Win32Exception), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000440 RID: 1088 RVA: 0x00003A5B File Offset: 0x00001C5B
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[MonitoringDescription("Returns the native handle for this process.   The handle is only available if the process was started using this component.")]
		[global::Cpp2ILInjected.Token(Token = "0x170000E3")]
		public IntPtr Handle
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004E0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EC83C8", Offset = "0x1EC83C8", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = "EnsureState", MemberParameters = new object[] { typeof(Process.State) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = "OpenProcessHandle", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(SafeProcessHandle))]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000441 RID: 1089 RVA: 0x00003A5E File Offset: 0x00001C5E
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[MonitoringDescription("The unique identifier for the process.")]
		[global::Cpp2ILInjected.Token(Token = "0x170000E4")]
		public int Id
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004E1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EC5A14", Offset = "0x1EC5A14", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = "EnsureState", MemberParameters = new object[] { typeof(Process.State) }, ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000DF RID: 223
		// (set) Token: 0x06000442 RID: 1090 RVA: 0x00003A61 File Offset: 0x00001C61
		[MonitoringDescription("The priority that the threads in the process run relative to.")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[global::Cpp2ILInjected.Token(Token = "0x170000E5")]
		public ProcessPriorityClass PriorityClass
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004E2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EC8498", Offset = "0x1EC8498", Length = "0x284")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "LoadDedConfig", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Initializers.LaunchInitializer", Member = "LoadServerParameters", MemberParameters = new object[] { "Terraria.Main" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "IsDefined", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = "GetProcessHandle", MemberParameters = new object[]
			{
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(SafeProcessHandle))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NativeMethods), Member = "SetPriorityClass", MemberParameters = new object[]
			{
				typeof(SafeProcessHandle),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "Close", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidEnumArgumentException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(int),
				typeof(Type)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Win32Exception), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000443 RID: 1091 RVA: 0x00003A64 File Offset: 0x00001C64
		// (set) Token: 0x06000444 RID: 1092 RVA: 0x00003A67 File Offset: 0x00001C67
		[MonitoringDescription("Specifies information used to start a process.")]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[global::Cpp2ILInjected.Token(Token = "0x170000E6")]
		public ProcessStartInfo StartInfo
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004E3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EC8724", Offset = "0x1EC8724", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "Start", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ProcessStartInfo), Member = ".ctor", MemberParameters = new object[] { typeof(Process) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60004E4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EC8804", Offset = "0x1EC8804", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.OS.OSX.Clipboard", Member = "GetClipboard", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.OS.OSX.Clipboard", Member = "SetClipboard", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.OS.Linux.Clipboard", Member = "GetClipboard", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.OS.Linux.Clipboard", Member = "ClearClipboard", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.OS.Linux.Clipboard", Member = "SetClipboard", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "Start", MemberParameters = new object[] { typeof(ProcessStartInfo) }, ReturnType = typeof(Process))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000445 RID: 1093 RVA: 0x00003A6A File Offset: 0x00001C6A
		[DefaultValue(null)]
		[MonitoringDescription("The object used to marshal the event handler calls issued as a result of a Process exit.")]
		[Browsable(false)]
		[global::Cpp2ILInjected.Token(Token = "0x170000E7")]
		public ISynchronizeInvoke SynchronizingObject
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004E5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EC8860", Offset = "0x1EC8860", Length = "0x1A4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "OnExited", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_DesignMode", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000446 RID: 1094 RVA: 0x00003A6D File Offset: 0x00001C6D
		[Browsable(false)]
		[MonitoringDescription("Standard input stream of the process.")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[global::Cpp2ILInjected.Token(Token = "0x170000E8")]
		public StreamWriter StandardInput
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004E6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EC8A04", Offset = "0x1EC8A04", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.OS.OSX.Clipboard", Member = "SetClipboard", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.OS.Linux.Clipboard", Member = "SetClipboard", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000447 RID: 1095 RVA: 0x00003A70 File Offset: 0x00001C70
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[MonitoringDescription("Standard output stream of the process.")]
		[global::Cpp2ILInjected.Token(Token = "0x170000E9")]
		public StreamReader StandardOutput
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004E7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EC8A7C", Offset = "0x1EC8A7C", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.OS.OSX.Clipboard", Member = "GetClipboard", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.OS.Linux.Clipboard", Member = "GetClipboard", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x00003A73 File Offset: 0x00001C73
		[global::Cpp2ILInjected.Token(Token = "0x60004E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC8B10", Offset = "0x1EC8B10", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "Close", ReturnType = typeof(void))]
		private void ReleaseProcessHandle(SafeProcessHandle handle)
		{
			throw null;
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x00003A76 File Offset: 0x00001C76
		[global::Cpp2ILInjected.Token(Token = "0x60004E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC8B38", Offset = "0x1EC8B38", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = "StopWatchingForExit", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = "RaiseOnExited", ReturnType = typeof(void))]
		private void CompletionCallback(object context, bool wasSignaled)
		{
			throw null;
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x00003A79 File Offset: 0x00001C79
		[global::Cpp2ILInjected.Token(Token = "0x60004EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC8C4C", Offset = "0x1EC8C4C", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00003A7C File Offset: 0x00001C7C
		[global::Cpp2ILInjected.Token(Token = "0x60004EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC8C9C", Offset = "0x1EC8C9C", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "Start", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = "StopWatchingForExit", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Close()
		{
			throw null;
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x00003A7F File Offset: 0x00001C7F
		[global::Cpp2ILInjected.Token(Token = "0x60004EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC7C10", Offset = "0x1EC7C10", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TraceEventCache), Member = "InitProcessInfo", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "get_HasExited", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "get_Handle", ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "get_Id", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "EnsureState", MemberParameters = new object[] { typeof(Process.State) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "GetProcessHandle", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(SafeProcessHandle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "CreatePipe", MemberParameters = new object[]
		{
			typeof(ref IntPtr),
			typeof(ref IntPtr),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = "get_HasExited", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = "EnsureState", MemberParameters = new object[] { typeof(Process.State) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private void EnsureState(Process.State state)
		{
			throw null;
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x00003A82 File Offset: 0x00001C82
		[global::Cpp2ILInjected.Token(Token = "0x60004ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC8E00", Offset = "0x1EC8E00", Length = "0x21C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "OpenProcessHandle", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(SafeProcessHandle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "SetProcessHandle", MemberParameters = new object[] { typeof(SafeProcessHandle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "StartWithShellExecuteEx", MemberParameters = new object[] { typeof(ProcessStartInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "StartWithCreateProcess", MemberParameters = new object[] { typeof(ProcessStartInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ProcessWaitHandle), Member = ".ctor", MemberParameters = new object[] { typeof(SafeProcessHandle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WaitOrTimerCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadPool), Member = "RegisterWaitForSingleObject", MemberParameters = new object[]
		{
			typeof(WaitHandle),
			typeof(WaitOrTimerCallback),
			typeof(object),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(RegisteredWaitHandle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		private void EnsureWatchingForExit()
		{
			throw null;
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x00003A85 File Offset: 0x00001C85
		[global::Cpp2ILInjected.Token(Token = "0x60004EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC5994", Offset = "0x1EC5994", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "LoadDedConfig", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Initializers.LaunchInitializer", Member = "LoadServerParameters", MemberParameters = new object[] { "Terraria.Main" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TraceEventCache), Member = "InitProcessInfo", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "CreatePipe", MemberParameters = new object[]
		{
			typeof(ref IntPtr),
			typeof(ref IntPtr),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NativeMethods), Member = "GetCurrentProcessId", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(int),
			typeof(ProcessInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static Process GetCurrentProcess()
		{
			throw null;
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x00003A88 File Offset: 0x00001C88
		[global::Cpp2ILInjected.Token(Token = "0x60004EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC901C", Offset = "0x1EC901C", Length = "0x218")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "RaiseOnExited", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = "get_SynchronizingObject", ReturnType = typeof(ISynchronizeInvoke))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		protected void OnExited()
		{
			throw null;
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x00003A8B File Offset: 0x00001C8B
		[global::Cpp2ILInjected.Token(Token = "0x60004F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC7D38", Offset = "0x1EC7D38", Length = "0x460")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "get_HasExited", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "set_PriorityClass", MemberParameters = new object[] { typeof(ProcessPriorityClass) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "GetProcessHandle", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(SafeProcessHandle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "OpenProcessHandle", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(SafeProcessHandle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "WaitForExit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "get_ProcessName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ProcessWaitHandle), Member = ".ctor", MemberParameters = new object[] { typeof(SafeProcessHandle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = "EnsureState", MemberParameters = new object[] { typeof(Process.State) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NativeMethods), Member = "GetCurrentProcess", ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HandleRef), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NativeMethods), Member = "DuplicateHandle", MemberParameters = new object[]
		{
			typeof(HandleRef),
			typeof(HandleRef),
			typeof(HandleRef),
			typeof(ref SafeProcessHandle),
			typeof(int),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NativeMethods), Member = "GetExitCodeProcess", MemberParameters = new object[]
		{
			typeof(SafeProcessHandle),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Win32Exception), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 41)]
		private SafeProcessHandle GetProcessHandle(int access, bool throwIfExited)
		{
			throw null;
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x00003A8E File Offset: 0x00001C8E
		[global::Cpp2ILInjected.Token(Token = "0x60004F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC871C", Offset = "0x1EC871C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = "GetProcessHandle", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(SafeProcessHandle))]
		private SafeProcessHandle GetProcessHandle(int access)
		{
			throw null;
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x00003A91 File Offset: 0x00001C91
		[global::Cpp2ILInjected.Token(Token = "0x60004F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC83F0", Offset = "0x1EC83F0", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "get_Handle", ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "CreatePipe", MemberParameters = new object[]
		{
			typeof(ref IntPtr),
			typeof(ref IntPtr),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = "GetProcessHandle", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(SafeProcessHandle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = "EnsureWatchingForExit", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private SafeProcessHandle OpenProcessHandle(int access)
		{
			throw null;
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x00003A94 File Offset: 0x00001C94
		[global::Cpp2ILInjected.Token(Token = "0x60004F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC8DEC", Offset = "0x1EC8DEC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Refresh()
		{
			throw null;
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x00003A97 File Offset: 0x00001C97
		[global::Cpp2ILInjected.Token(Token = "0x60004F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC9234", Offset = "0x1EC9234", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = "EnsureWatchingForExit", ReturnType = typeof(void))]
		private void SetProcessHandle(SafeProcessHandle processHandle)
		{
			throw null;
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x00003A9A File Offset: 0x00001C9A
		[global::Cpp2ILInjected.Token(Token = "0x60004F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC9250", Offset = "0x1EC9250", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void SetProcessId(int processId)
		{
			throw null;
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x00003A9D File Offset: 0x00001C9D
		[global::Cpp2ILInjected.Token(Token = "0x60004F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC9260", Offset = "0x1EC9260", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.OS.OSX.Clipboard", Member = "GetClipboard", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.OS.OSX.Clipboard", Member = "SetClipboard", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.OS.Linux.Clipboard", Member = "GetClipboard", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.OS.Linux.Clipboard", Member = "ClearClipboard", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.OS.Linux.Clipboard", Member = "SetClipboard", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "Start", MemberParameters = new object[] { typeof(ProcessStartInfo) }, ReturnType = typeof(Process))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = "get_StartInfo", ReturnType = typeof(ProcessStartInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = "StartWithShellExecuteEx", MemberParameters = new object[] { typeof(ProcessStartInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = "StartWithCreateProcess", MemberParameters = new object[] { typeof(ProcessStartInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public bool Start()
		{
			throw null;
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x00003AA0 File Offset: 0x00001CA0
		[global::Cpp2ILInjected.Token(Token = "0x60004F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECA9F8", Offset = "0x1ECA9F8", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Utils", Member = "OpenFolder", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = "Start", MemberParameters = new object[] { typeof(ProcessStartInfo) }, ReturnType = typeof(Process))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Process Start(string fileName)
		{
			throw null;
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x00003AA3 File Offset: 0x00001CA3
		[global::Cpp2ILInjected.Token(Token = "0x60004F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECAA8C", Offset = "0x1ECAA8C", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "Start", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Process))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = "set_StartInfo", MemberParameters = new object[] { typeof(ProcessStartInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = "Start", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static Process Start(ProcessStartInfo startInfo)
		{
			throw null;
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x00003AA6 File Offset: 0x00001CA6
		[global::Cpp2ILInjected.Token(Token = "0x60004F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC8B50", Offset = "0x1EC8B50", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "CompletionCallback", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegisteredWaitHandle), Member = "Unregister", MemberParameters = new object[] { typeof(WaitHandle) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void StopWatchingForExit()
		{
			throw null;
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00003AA9 File Offset: 0x00001CA9
		[global::Cpp2ILInjected.Token(Token = "0x60004FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECAB44", Offset = "0x1ECAB44", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = "get_ProcessName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(IFormatProvider),
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x00003AAC File Offset: 0x00001CAC
		[global::Cpp2ILInjected.Token(Token = "0x60004FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECACA8", Offset = "0x1ECACA8", Length = "0x25C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "WaitForExit", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = "GetProcessHandle", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(SafeProcessHandle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ProcessWaitHandle), Member = ".ctor", MemberParameters = new object[] { typeof(SafeProcessHandle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = "RaiseOnExited", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public bool WaitForExit(int milliseconds)
		{
			throw null;
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x00003AAF File Offset: 0x00001CAF
		[global::Cpp2ILInjected.Token(Token = "0x60004FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECAF04", Offset = "0x1ECAF04", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.OS.OSX.Clipboard", Member = "GetClipboard", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.OS.OSX.Clipboard", Member = "SetClipboard", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.OS.Linux.Clipboard", Member = "GetClipboard", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.OS.Linux.Clipboard", Member = "ClearClipboard", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.OS.Linux.Clipboard", Member = "SetClipboard", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = "WaitForExit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		public void WaitForExit()
		{
			throw null;
		}

		// Token: 0x0600045D RID: 1117
		[global::Cpp2ILInjected.Token(Token = "0x60004FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECAF0C", Offset = "0x1ECAF0C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern string ProcessName_icall(IntPtr handle);

		// Token: 0x0600045E RID: 1118 RVA: 0x00003AB2 File Offset: 0x00001CB2
		[global::Cpp2ILInjected.Token(Token = "0x60004FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECAF10", Offset = "0x1ECAF10", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "get_ProcessName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private static string ProcessName_internal(SafeProcessHandle handle)
		{
			throw null;
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x0600045F RID: 1119 RVA: 0x00003AB5 File Offset: 0x00001CB5
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[MonitoringDescription("The name of this process.")]
		[global::Cpp2ILInjected.Token(Token = "0x170000EA")]
		public string ProcessName
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004FF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EC5A30", Offset = "0x1EC5A30", Length = "0x204")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TraceEventCache), Member = "InitProcessInfo", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "ToString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = "GetProcessHandle", MemberParameters = new object[]
			{
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(SafeProcessHandle))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = "ProcessName_internal", MemberParameters = new object[] { typeof(SafeProcessHandle) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "Close", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000460 RID: 1120
		[global::Cpp2ILInjected.Token(Token = "0x6000500")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECAFD4", Offset = "0x1ECAFD4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern bool ShellExecuteEx_internal(ProcessStartInfo startInfo, ref Process.ProcInfo procInfo);

		// Token: 0x06000461 RID: 1121
		[global::Cpp2ILInjected.Token(Token = "0x6000501")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECAFD8", Offset = "0x1ECAFD8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern bool CreateProcess_internal(ProcessStartInfo startInfo, IntPtr stdin, IntPtr stdout, IntPtr stderr, ref Process.ProcInfo procInfo);

		// Token: 0x06000462 RID: 1122 RVA: 0x00003AB8 File Offset: 0x00001CB8
		[global::Cpp2ILInjected.Token(Token = "0x6000502")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC939C", Offset = "0x1EC939C", Length = "0x398")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "Start", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = "FillUserInfo", MemberParameters = new object[]
		{
			typeof(ProcessStartInfo),
			typeof(ref Process.ProcInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(IntPtr)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Marshal), Member = "ZeroFreeBSTR", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeProcessHandle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = "EnsureWatchingForExit", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Win32Exception), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		private bool StartWithShellExecuteEx(ProcessStartInfo startInfo)
		{
			throw null;
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x00003ABB File Offset: 0x00001CBB
		[global::Cpp2ILInjected.Token(Token = "0x6000503")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECB164", Offset = "0x1ECB164", Length = "0x1C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "StartWithCreateProcess", MemberParameters = new object[] { typeof(ProcessStartInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.IO.MonoIO", Member = "CreatePipe", MemberParameters = new object[]
		{
			typeof(ref IntPtr),
			typeof(ref IntPtr),
			typeof(ref MonoIOError)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_OSVersion", ReturnType = typeof(OperatingSystem))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = "GetCurrentProcess", ReturnType = typeof(Process))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = "EnsureState", MemberParameters = new object[] { typeof(Process.State) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = "OpenProcessHandle", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(SafeProcessHandle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.IO.MonoIO", Member = "DuplicateHandle", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(IntPtr),
			typeof(IntPtr),
			typeof(ref IntPtr),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(ref MonoIOError)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.IO.MonoIO", Member = "Close", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(ref MonoIOError)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.IO.MonoIO", Member = "GetException", MemberParameters = new object[] { "System.IO.MonoIOError" }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private static void CreatePipe(out IntPtr read, out IntPtr write, bool writeDirection)
		{
			throw null;
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000464 RID: 1124 RVA: 0x00003ABE File Offset: 0x00001CBE
		[global::Cpp2ILInjected.Token(Token = "0x170000EB")]
		private static bool IsWindows
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000504")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ECB328", Offset = "0x1ECB328", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_OSVersion", ReturnType = typeof(OperatingSystem))]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x00003AC1 File Offset: 0x00001CC1
		[global::Cpp2ILInjected.Token(Token = "0x6000505")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC9734", Offset = "0x1EC9734", Length = "0x12C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "Start", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ProcessStartInfo), Member = "get_EnvironmentVariables", ReturnType = typeof(StringDictionary))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "ToArray", ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ProcessStartInfo), Member = "get_ArgumentList", ReturnType = typeof(Collection<string>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collection<>), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collection<>), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PasteArguments), Member = "AppendArgument", MemberParameters = new object[]
		{
			typeof(StringBuilder),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = "CreatePipe", MemberParameters = new object[]
		{
			typeof(ref IntPtr),
			typeof(ref IntPtr),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.IO.MonoIO", Member = "get_ConsoleInput", ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.IO.MonoIO", Member = "get_ConsoleOutput", ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.IO.MonoIO", Member = "get_ConsoleError", ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = "FillUserInfo", MemberParameters = new object[]
		{
			typeof(ProcessStartInfo),
			typeof(ref Process.ProcInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(IntPtr)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Marshal), Member = "ZeroFreeBSTR", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeProcessHandle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = "EnsureWatchingForExit", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.IO.MonoIO", Member = "Close", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(ref MonoIOError)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_Default", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(FileAccess),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(Encoding)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamReader), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(Encoding),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Win32Exception), Member = "GetErrorMessage", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Win32Exception), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 146)]
		private bool StartWithCreateProcess(ProcessStartInfo startInfo)
		{
			throw null;
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x00003AC4 File Offset: 0x00001CC4
		[global::Cpp2ILInjected.Token(Token = "0x6000506")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECB030", Offset = "0x1ECB030", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "StartWithShellExecuteEx", MemberParameters = new object[] { typeof(ProcessStartInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "StartWithCreateProcess", MemberParameters = new object[] { typeof(ProcessStartInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Marshal), Member = "SecureStringToBSTR", MemberParameters = new object[] { typeof(SecureString) }, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static void FillUserInfo(ProcessStartInfo startInfo, ref Process.ProcInfo procInfo)
		{
			throw null;
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x00003AC7 File Offset: 0x00001CC7
		[global::Cpp2ILInjected.Token(Token = "0x6000507")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC82E8", Offset = "0x1EC82E8", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "get_HasExited", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "CompletionCallback", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "WaitForExit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = "OnExited", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void RaiseOnExited()
		{
			throw null;
		}

		// Token: 0x04000288 RID: 648
		[global::Cpp2ILInjected.Token(Token = "0x40003C9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private bool haveProcessId;

		// Token: 0x04000289 RID: 649
		[global::Cpp2ILInjected.Token(Token = "0x40003CA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private int processId;

		// Token: 0x0400028A RID: 650
		[global::Cpp2ILInjected.Token(Token = "0x40003CB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private bool haveProcessHandle;

		// Token: 0x0400028B RID: 651
		[global::Cpp2ILInjected.Token(Token = "0x40003CC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private SafeProcessHandle m_processHandle;

		// Token: 0x0400028C RID: 652
		[global::Cpp2ILInjected.Token(Token = "0x40003CD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private bool isRemoteMachine;

		// Token: 0x0400028D RID: 653
		[global::Cpp2ILInjected.Token(Token = "0x40003CE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private string machineName;

		// Token: 0x0400028E RID: 654
		[global::Cpp2ILInjected.Token(Token = "0x40003CF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private int m_processAccess;

		// Token: 0x0400028F RID: 655
		[global::Cpp2ILInjected.Token(Token = "0x40003D0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private ProcessThreadCollection threads;

		// Token: 0x04000290 RID: 656
		[global::Cpp2ILInjected.Token(Token = "0x40003D1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private ProcessModuleCollection modules;

		// Token: 0x04000291 RID: 657
		[global::Cpp2ILInjected.Token(Token = "0x40003D2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private bool haveWorkingSetLimits;

		// Token: 0x04000292 RID: 658
		[global::Cpp2ILInjected.Token(Token = "0x40003D3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x69")]
		private bool havePriorityClass;

		// Token: 0x04000293 RID: 659
		[global::Cpp2ILInjected.Token(Token = "0x40003D4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
		private ProcessPriorityClass priorityClass;

		// Token: 0x04000294 RID: 660
		[global::Cpp2ILInjected.Token(Token = "0x40003D5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private ProcessStartInfo startInfo;

		// Token: 0x04000295 RID: 661
		[global::Cpp2ILInjected.Token(Token = "0x40003D6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private bool watchForExit;

		// Token: 0x04000296 RID: 662
		[global::Cpp2ILInjected.Token(Token = "0x40003D7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x79")]
		private bool watchingForExit;

		// Token: 0x04000297 RID: 663
		[global::Cpp2ILInjected.Token(Token = "0x40003D8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private EventHandler onExited;

		// Token: 0x04000298 RID: 664
		[global::Cpp2ILInjected.Token(Token = "0x40003D9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private bool exited;

		// Token: 0x04000299 RID: 665
		[global::Cpp2ILInjected.Token(Token = "0x40003DA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8C")]
		private int exitCode;

		// Token: 0x0400029A RID: 666
		[global::Cpp2ILInjected.Token(Token = "0x40003DB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private bool signaled;

		// Token: 0x0400029B RID: 667
		[global::Cpp2ILInjected.Token(Token = "0x40003DC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x91")]
		private bool haveExitTime;

		// Token: 0x0400029C RID: 668
		[global::Cpp2ILInjected.Token(Token = "0x40003DD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x92")]
		private bool raisedOnExited;

		// Token: 0x0400029D RID: 669
		[global::Cpp2ILInjected.Token(Token = "0x40003DE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private RegisteredWaitHandle registeredWaitHandle;

		// Token: 0x0400029E RID: 670
		[global::Cpp2ILInjected.Token(Token = "0x40003DF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private WaitHandle waitHandle;

		// Token: 0x0400029F RID: 671
		[global::Cpp2ILInjected.Token(Token = "0x40003E0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		private ISynchronizeInvoke synchronizingObject;

		// Token: 0x040002A0 RID: 672
		[global::Cpp2ILInjected.Token(Token = "0x40003E1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		private StreamReader standardOutput;

		// Token: 0x040002A1 RID: 673
		[global::Cpp2ILInjected.Token(Token = "0x40003E2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		private StreamWriter standardInput;

		// Token: 0x040002A2 RID: 674
		[global::Cpp2ILInjected.Token(Token = "0x40003E3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		private StreamReader standardError;

		// Token: 0x040002A3 RID: 675
		[global::Cpp2ILInjected.Token(Token = "0x40003E4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		private bool disposed;

		// Token: 0x040002A4 RID: 676
		[global::Cpp2ILInjected.Token(Token = "0x40003E5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xCC")]
		private Process.StreamReadMode outputStreamReadMode;

		// Token: 0x040002A5 RID: 677
		[global::Cpp2ILInjected.Token(Token = "0x40003E6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		private Process.StreamReadMode errorStreamReadMode;

		// Token: 0x040002A6 RID: 678
		[global::Cpp2ILInjected.Token(Token = "0x40003E7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD4")]
		private Process.StreamReadMode inputStreamReadMode;

		// Token: 0x040002A7 RID: 679
		[global::Cpp2ILInjected.Token(Token = "0x40003E8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		internal AsyncStreamReader output;

		// Token: 0x040002A8 RID: 680
		[global::Cpp2ILInjected.Token(Token = "0x40003E9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
		internal AsyncStreamReader error;

		// Token: 0x040002A9 RID: 681
		[global::Cpp2ILInjected.Token(Token = "0x40003EA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
		private string process_name;

		// Token: 0x020003C0 RID: 960
		[global::Cpp2ILInjected.Token(Token = "0x20000D7")]
		private enum StreamReadMode
		{
			// Token: 0x040010F3 RID: 4339
			[global::Cpp2ILInjected.Token(Token = "0x40003EC")]
			undefined,
			// Token: 0x040010F4 RID: 4340
			[global::Cpp2ILInjected.Token(Token = "0x40003ED")]
			syncMode,
			// Token: 0x040010F5 RID: 4341
			[global::Cpp2ILInjected.Token(Token = "0x40003EE")]
			asyncMode
		}

		// Token: 0x020003C1 RID: 961
		[global::Cpp2ILInjected.Token(Token = "0x20000D8")]
		private enum State
		{
			// Token: 0x040010F7 RID: 4343
			[global::Cpp2ILInjected.Token(Token = "0x40003F0")]
			HaveId = 1,
			// Token: 0x040010F8 RID: 4344
			[global::Cpp2ILInjected.Token(Token = "0x40003F1")]
			IsLocal,
			// Token: 0x040010F9 RID: 4345
			[global::Cpp2ILInjected.Token(Token = "0x40003F2")]
			IsNt = 4,
			// Token: 0x040010FA RID: 4346
			[global::Cpp2ILInjected.Token(Token = "0x40003F3")]
			HaveProcessInfo = 8,
			// Token: 0x040010FB RID: 4347
			[global::Cpp2ILInjected.Token(Token = "0x40003F4")]
			Exited = 16,
			// Token: 0x040010FC RID: 4348
			[global::Cpp2ILInjected.Token(Token = "0x40003F5")]
			Associated = 32,
			// Token: 0x040010FD RID: 4349
			[global::Cpp2ILInjected.Token(Token = "0x40003F6")]
			IsWin2k = 64,
			// Token: 0x040010FE RID: 4350
			[global::Cpp2ILInjected.Token(Token = "0x40003F7")]
			HaveNtProcessInfo = 12
		}

		// Token: 0x020003C2 RID: 962
		[global::Cpp2ILInjected.Token(Token = "0x20000D9")]
		private struct ProcInfo
		{
			// Token: 0x040010FF RID: 4351
			[global::Cpp2ILInjected.Token(Token = "0x40003F8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public IntPtr process_handle;

			// Token: 0x04001100 RID: 4352
			[global::Cpp2ILInjected.Token(Token = "0x40003F9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public int pid;

			// Token: 0x04001101 RID: 4353
			[global::Cpp2ILInjected.Token(Token = "0x40003FA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public string[] envVariables;

			// Token: 0x04001102 RID: 4354
			[global::Cpp2ILInjected.Token(Token = "0x40003FB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public string UserName;

			// Token: 0x04001103 RID: 4355
			[global::Cpp2ILInjected.Token(Token = "0x40003FC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public string Domain;

			// Token: 0x04001104 RID: 4356
			[global::Cpp2ILInjected.Token(Token = "0x40003FD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public IntPtr Password;

			// Token: 0x04001105 RID: 4357
			[global::Cpp2ILInjected.Token(Token = "0x40003FE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public bool LoadUserProfile;
		}
	}
}
