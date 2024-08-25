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
	[DefaultEvent("Exited")]
	[MonitoringDescription("Provides access to local and remote processes, enabling starting and stopping of local processes.")]
	[DefaultProperty("StartInfo")]
	[global::Cpp2ILInjected.Token(Token = "0x20000D6")]
	public class Process : Component
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x60004E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC8B10", Offset = "0x1EC8B10", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "Close", ReturnType = typeof(void))]
		private void ReleaseProcessHandle(SafeProcessHandle handle)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60004E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC8B38", Offset = "0x1EC8B38", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = "StopWatchingForExit", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = "RaiseOnExited", ReturnType = typeof(void))]
		private void CompletionCallback(object context, bool wasSignaled)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60004EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC8C4C", Offset = "0x1EC8C4C", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		protected override void Dispose(bool disposing)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x60004F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC8DEC", Offset = "0x1EC8DEC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Refresh()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60004F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC9234", Offset = "0x1EC9234", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = "EnsureWatchingForExit", ReturnType = typeof(void))]
		private void SetProcessHandle(SafeProcessHandle processHandle)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60004F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC9250", Offset = "0x1EC9250", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void SetProcessId(int processId)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x60004FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECAF0C", Offset = "0x1ECAF0C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern string ProcessName_icall(IntPtr handle);

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

		[global::Cpp2ILInjected.Token(Token = "0x6000500")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECAFD4", Offset = "0x1ECAFD4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern bool ShellExecuteEx_internal(ProcessStartInfo startInfo, ref Process.ProcInfo procInfo);

		[global::Cpp2ILInjected.Token(Token = "0x6000501")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECAFD8", Offset = "0x1ECAFD8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern bool CreateProcess_internal(ProcessStartInfo startInfo, IntPtr stdin, IntPtr stdout, IntPtr stderr, ref Process.ProcInfo procInfo);

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

		[global::Cpp2ILInjected.Token(Token = "0x40003C9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private bool haveProcessId;

		[global::Cpp2ILInjected.Token(Token = "0x40003CA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private int processId;

		[global::Cpp2ILInjected.Token(Token = "0x40003CB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private bool haveProcessHandle;

		[global::Cpp2ILInjected.Token(Token = "0x40003CC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private SafeProcessHandle m_processHandle;

		[global::Cpp2ILInjected.Token(Token = "0x40003CD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private bool isRemoteMachine;

		[global::Cpp2ILInjected.Token(Token = "0x40003CE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private string machineName;

		[global::Cpp2ILInjected.Token(Token = "0x40003CF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private int m_processAccess;

		[global::Cpp2ILInjected.Token(Token = "0x40003D0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private ProcessThreadCollection threads;

		[global::Cpp2ILInjected.Token(Token = "0x40003D1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private ProcessModuleCollection modules;

		[global::Cpp2ILInjected.Token(Token = "0x40003D2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private bool haveWorkingSetLimits;

		[global::Cpp2ILInjected.Token(Token = "0x40003D3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x69")]
		private bool havePriorityClass;

		[global::Cpp2ILInjected.Token(Token = "0x40003D4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
		private ProcessPriorityClass priorityClass;

		[global::Cpp2ILInjected.Token(Token = "0x40003D5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private ProcessStartInfo startInfo;

		[global::Cpp2ILInjected.Token(Token = "0x40003D6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private bool watchForExit;

		[global::Cpp2ILInjected.Token(Token = "0x40003D7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x79")]
		private bool watchingForExit;

		[global::Cpp2ILInjected.Token(Token = "0x40003D8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private EventHandler onExited;

		[global::Cpp2ILInjected.Token(Token = "0x40003D9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private bool exited;

		[global::Cpp2ILInjected.Token(Token = "0x40003DA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8C")]
		private int exitCode;

		[global::Cpp2ILInjected.Token(Token = "0x40003DB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private bool signaled;

		[global::Cpp2ILInjected.Token(Token = "0x40003DC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x91")]
		private bool haveExitTime;

		[global::Cpp2ILInjected.Token(Token = "0x40003DD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x92")]
		private bool raisedOnExited;

		[global::Cpp2ILInjected.Token(Token = "0x40003DE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private RegisteredWaitHandle registeredWaitHandle;

		[global::Cpp2ILInjected.Token(Token = "0x40003DF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private WaitHandle waitHandle;

		[global::Cpp2ILInjected.Token(Token = "0x40003E0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		private ISynchronizeInvoke synchronizingObject;

		[global::Cpp2ILInjected.Token(Token = "0x40003E1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		private StreamReader standardOutput;

		[global::Cpp2ILInjected.Token(Token = "0x40003E2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		private StreamWriter standardInput;

		[global::Cpp2ILInjected.Token(Token = "0x40003E3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		private StreamReader standardError;

		[global::Cpp2ILInjected.Token(Token = "0x40003E4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		private bool disposed;

		[global::Cpp2ILInjected.Token(Token = "0x40003E5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xCC")]
		private Process.StreamReadMode outputStreamReadMode;

		[global::Cpp2ILInjected.Token(Token = "0x40003E6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		private Process.StreamReadMode errorStreamReadMode;

		[global::Cpp2ILInjected.Token(Token = "0x40003E7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD4")]
		private Process.StreamReadMode inputStreamReadMode;

		[global::Cpp2ILInjected.Token(Token = "0x40003E8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		internal AsyncStreamReader output;

		[global::Cpp2ILInjected.Token(Token = "0x40003E9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
		internal AsyncStreamReader error;

		[global::Cpp2ILInjected.Token(Token = "0x40003EA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
		private string process_name;

		[global::Cpp2ILInjected.Token(Token = "0x20000D7")]
		private enum StreamReadMode
		{
			[global::Cpp2ILInjected.Token(Token = "0x40003EC")]
			undefined,
			[global::Cpp2ILInjected.Token(Token = "0x40003ED")]
			syncMode,
			[global::Cpp2ILInjected.Token(Token = "0x40003EE")]
			asyncMode
		}

		[global::Cpp2ILInjected.Token(Token = "0x20000D8")]
		private enum State
		{
			[global::Cpp2ILInjected.Token(Token = "0x40003F0")]
			HaveId = 1,
			[global::Cpp2ILInjected.Token(Token = "0x40003F1")]
			IsLocal,
			[global::Cpp2ILInjected.Token(Token = "0x40003F2")]
			IsNt = 4,
			[global::Cpp2ILInjected.Token(Token = "0x40003F3")]
			HaveProcessInfo = 8,
			[global::Cpp2ILInjected.Token(Token = "0x40003F4")]
			Exited = 16,
			[global::Cpp2ILInjected.Token(Token = "0x40003F5")]
			Associated = 32,
			[global::Cpp2ILInjected.Token(Token = "0x40003F6")]
			IsWin2k = 64,
			[global::Cpp2ILInjected.Token(Token = "0x40003F7")]
			HaveNtProcessInfo = 12
		}

		[global::Cpp2ILInjected.Token(Token = "0x20000D9")]
		private struct ProcInfo
		{
			[global::Cpp2ILInjected.Token(Token = "0x40003F8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public IntPtr process_handle;

			[global::Cpp2ILInjected.Token(Token = "0x40003F9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public int pid;

			[global::Cpp2ILInjected.Token(Token = "0x40003FA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public string[] envVariables;

			[global::Cpp2ILInjected.Token(Token = "0x40003FB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public string UserName;

			[global::Cpp2ILInjected.Token(Token = "0x40003FC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public string Domain;

			[global::Cpp2ILInjected.Token(Token = "0x40003FD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public IntPtr Password;

			[global::Cpp2ILInjected.Token(Token = "0x40003FE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public bool LoadUserProfile;
		}
	}
}
