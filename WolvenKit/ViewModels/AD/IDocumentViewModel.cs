﻿using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WolvenKit.ViewModels
{
	public interface IDocumentViewModel
	{
		/// <summary>
		/// Gets the current filename of the file being managed in this document viewmodel.
		/// </summary>
		string FileName { get; }

		/// <summary>
		/// Gets the current path of the file being managed in this document viewmodel.
		/// </summary>
		string FilePath { get; }

        /// <summary>
		/// Gets/sets whether the documents content has been changed without saving into file system or not.
		/// </summary>
		bool IsDirty { get; set; }

		/// <summary>
		/// Gets a command to close this document.
		/// </summary>
		ICommand CloseCommand { get; }

		/// <summary>
		/// Gets a command to save this document's content into the file system.
		/// </summary>
		ICommand SaveCommand { get; }

		/// <summary>
		/// Gets a command to save this document's content into another file in the file system.
		/// </summary>
		ICommand SaveAsCommand { get; }

        /// <summary>
		/// Attempts to read the contents of a text file and assigns it to
		/// text content of this viewmodel.
		/// </summary>
		/// <param name="path"></param>
		/// <returns>True if file read was successful, otherwise false</returns>
		Task<bool> OpenFileAsync(string path);

		/// <summary>
		/// Attempts to read the contents of a text file defined via initialPath
		/// and assigns it to text content of this viewmodel.
		/// </summary>
		/// <param name="path"></param>
		/// <returns>True if file read was successful, otherwise false</returns>
		Task<bool> OpenFileWithInitialPathAsync();
	}
}