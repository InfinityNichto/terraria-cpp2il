using System;
using Cpp2ILInjected;
using ReLogic.Content.Sources;

namespace ReLogic.Content
{
	[global::Cpp2ILInjected.Token(Token = "0x2000B4B")]
	public interface IAsyncAssetLoader : IDisposable
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000923")]
		bool IsRunning
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005415")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000924")]
		int Remaining
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005416")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005417")]
		void Start();

		[global::Cpp2ILInjected.Token(Token = "0x6005418")]
		void Stop();

		[global::Cpp2ILInjected.Token(Token = "0x6005419")]
		void Load<T>(string assetName, IContentSource source, LoadAssetDelegate<T> callback) where T : class;

		[global::Cpp2ILInjected.Token(Token = "0x600541A")]
		void TransferCompleted();
	}
}
