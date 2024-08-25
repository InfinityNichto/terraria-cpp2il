using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace ReLogic.OS.Windows
{
	[global::Cpp2ILInjected.Token(Token = "0x2000B24")]
	internal class STATaskInvoker : IDisposable
	{
		[global::Cpp2ILInjected.Token(Token = "0x6005350")]
		[global::Cpp2ILInjected.Address(RVA = "0x942F5C", Offset = "0x942F5C", Length = "0x190")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(STATaskInvoker), Member = "Invoke", MemberParameters = new object[] { typeof(Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(STATaskInvoker), Member = "Invoke", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.Func`1<T>" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BlockingCollection<>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadStart), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = ".ctor", MemberParameters = new object[] { typeof(ThreadStart) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "set_Name", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "SetApartmentState", MemberParameters = new object[] { typeof(ApartmentState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "Start", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private STATaskInvoker()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005351")]
		[global::Cpp2ILInjected.Address(RVA = "0x9430EC", Offset = "0x9430EC", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(STATaskInvoker), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void Invoke(Action action)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005352")]
		[global::Cpp2ILInjected.Address(RVA = "0x159B088", Offset = "0x159B088", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(STATaskInvoker), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(STATaskInvoker), Member = "InvokeAndWait", MemberParameters = new object[] { typeof(Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static T Invoke<T>(Func<T> action)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005353")]
		[global::Cpp2ILInjected.Address(RVA = "0x943168", Offset = "0x943168", Length = "0x1A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(STATaskInvoker), Member = "Invoke", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.Func`1<T>" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(STATaskInvoker), Member = "Shutdown", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BlockingCollection<>), Member = "Add", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Wait", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private void InvokeAndWait(Action action)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005354")]
		[global::Cpp2ILInjected.Address(RVA = "0x943310", Offset = "0x943310", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BlockingCollection<>), Member = "Take", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Pulse", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private void TaskThreadStart()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005355")]
		[global::Cpp2ILInjected.Address(RVA = "0x94343C", Offset = "0x94343C", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(STATaskInvoker), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(STATaskInvoker), Member = "InvokeAndWait", MemberParameters = new object[] { typeof(Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void Shutdown()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005356")]
		[global::Cpp2ILInjected.Address(RVA = "0x9434BC", Offset = "0x9434BC", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(STATaskInvoker), Member = "Shutdown", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BlockingCollection<>), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005357")]
		[global::Cpp2ILInjected.Address(RVA = "0x943530", Offset = "0x943530", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Dispose()
		{
			throw null;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x6005358")]
		[global::Cpp2ILInjected.Address(RVA = "0x943540", Offset = "0x943540", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void <Shutdown>b__11_0()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4008B16")]
		private static STATaskInvoker Instance;

		[global::Cpp2ILInjected.Token(Token = "0x4008B17")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Thread _staThread;

		[global::Cpp2ILInjected.Token(Token = "0x4008B18")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private bool _shouldThreadContinue;

		[global::Cpp2ILInjected.Token(Token = "0x4008B19")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private BlockingCollection<Action> _staTasks;

		[global::Cpp2ILInjected.Token(Token = "0x4008B1A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private object _taskInvokeLock;

		[global::Cpp2ILInjected.Token(Token = "0x4008B1B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private object _taskCompletionLock;

		[global::Cpp2ILInjected.Token(Token = "0x4008B1C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private bool disposedValue;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000B25")]
		private sealed class <>c__DisplayClass8_0<T>
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005359")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B459C", Offset = "0x15B459C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass8_0()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600535A")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B45A4", Offset = "0x15B45A4", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal void <Invoke>b__0()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4008B1D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public T output;

			[global::Cpp2ILInjected.Token(Token = "0x4008B1E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public Func<T> action;
		}
	}
}
