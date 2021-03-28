using DataFinder.DAL;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static DataFinder.BLL.BuisnessRuleException;

namespace DataFinder.BLL
{
    class FileService
    {
        public FileRepository fileRepository { get; }
        public FileService()
        {
            this.fileRepository = new FileRepository();
        }

        public IEnumerable<File> GetAllFiles()
        {
            return fileRepository.GetFilesByDirectory().ToList()
                .Select(fileEntity => new File(fileEntity));
        }

        public File GetFileByFileName(string fileName)
        {
            if (String.IsNullOrEmpty(fileName))
                throw new BusinessRuleException("Введите корректное значение!");

            var fileEntity = fileRepository.GetFileByFileName(fileName);
            if (fileEntity is null)
                throw new BusinessRuleException("Файл с указанным именем не обнаружен!");

            return new File(fileEntity);
        }
    }
}
