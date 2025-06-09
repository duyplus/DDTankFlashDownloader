using System.Windows.Forms;

namespace DDTankFlashDownloader
{
    public static class LanguageManager
    {
        public static void ApplyLanguage(Form1 form)
        {
            switch (form.cboLang.SelectedIndex)
            {
                case 0: // Vietnamese
                    form.lblFlashName.Text = "Tên thư mục:";
                    form.lblFlashLang.Text = "Ngôn ngữ Flash:";
                    form.btnDel.Text = "Xoá";
                    form.btnAdd.Text = "Thêm mới";
                    form.btnDelLang.Text = "Xoá";
                    form.btnAddLang.Text = "Thêm mới";
                    form.btnDelSwf.Text = "Xoá";
                    form.btnAddSwf.Text = "Thêm mới";
                    form.btnDelXml.Text = "Xoá";
                    form.btnAddXml.Text = "Thêm mới";
                    form.btnFetch.Text = "Bắt đầu tải !";
                    form.downloadingText = "Đang tải...";
                    form.startDownloadText = "Bắt đầu tải !";
                    form.errorOccurredText = "Đã xảy ra lỗi";
                    form.downloadCompletedText = "Tải xuống thành công!";
                    form.fieldFlashNameText = "Tên thư mục không được để trống.";
                    form.fieldFlashUrlText = "Đường dẫn Flash không được để trống.";
                    form.fieldFlashLangText = "Ngôn ngữ Flash không được để trống.";
                    form.invalidFileMessage = "Tệp tin không hợp lệ.";
                    form.allowedExtensionsText = "File phải có đuôi .png, .swf, hoặc .xml !";
                    form.allowedExtensionsPngText = "File phải có đuôi .png !";
                    form.allowedExtensionsSwfText = "File phải có đuôi .swf !";
                    form.allowedExtensionsLangText = "File phải có đuôi .png, .txt hoặc .xml !";
                    form.gbLang.Text = "Ngôn ngữ";
                    break;

                case 1: // English
                    form.lblFlashName.Text = "Folder name:";
                    form.lblFlashLang.Text = "Flash Lang:";
                    form.btnDel.Text = "Delete";
                    form.btnAdd.Text = "Add File";
                    form.btnDelLang.Text = "Delete";
                    form.btnAddLang.Text = "Add new";
                    form.btnDelSwf.Text = "Delete";
                    form.btnAddSwf.Text = "Add new";
                    form.btnDelXml.Text = "Delete";
                    form.btnAddXml.Text = "Add new";
                    form.btnFetch.Text = "Start Download !";
                    form.downloadingText = "Downloading...";
                    form.startDownloadText = "Start Download!";
                    form.errorOccurredText = "An error occurred";
                    form.downloadCompletedText = "Download completed successfully!";
                    form.fieldFlashNameText = "Folder name must not be empty.";
                    form.fieldFlashUrlText = "Flash URL must not be empty.";
                    form.fieldFlashLangText = "Flash language must not be empty.";
                    form.invalidFileMessage = "Invalid file.";
                    form.allowedExtensionsText = "File must have the .png, .swf, or .xml extension.";
                    form.allowedExtensionsPngText = "File must have the .png extension.";
                    form.allowedExtensionsSwfText = "File must have the .swf extension.";
                    form.allowedExtensionsLangText = "File must have the .png, .txt or .xml extension.";
                    form.gbLang.Text = "Language";
                    break;

                case 2: // Russian
                    form.lblFlashName.Text = "Имя папки:";
                    form.lblFlashLang.Text = "Язык Flash:";
                    form.btnDel.Text = "Удалить";
                    form.btnAdd.Text = "Добавить новый";
                    form.btnDelLang.Text = "Удалить";
                    form.btnAddLang.Text = "Добавить новый";
                    form.btnDelSwf.Text = "Удалить";
                    form.btnAddSwf.Text = "Добавить новый";
                    form.btnDelXml.Text = "Удалить";
                    form.btnAddXml.Text = "Добавить новый";
                    form.btnFetch.Text = "Начать загрузку !";
                    form.downloadingText = "Загрузка...";
                    form.startDownloadText = "Начать загрузку !";
                    form.errorOccurredText = "Произошла ошибка";
                    form.downloadCompletedText = "Загрузка завершена успешно!";
                    form.fieldFlashNameText = "Имя папки не должно быть пустым.";
                    form.fieldFlashUrlText = "URL-адрес Flash не должен быть пустым.";
                    form.fieldFlashLangText = "Язык Flash не должен быть пустым.";
                    form.invalidFileMessage = "Недопустимый файл.";
                    form.allowedExtensionsText = "Файл должен иметь расширение .png, .swf, или .xml !";
                    form.allowedExtensionsPngText = "Файл должен иметь расширение .png !";
                    form.allowedExtensionsSwfText = "Файл должен иметь расширение .swf !";
                    form.allowedExtensionsLangText = "Файл должен иметь расширение .png, .txt или .xml!";
                    form.gbLang.Text = "Язык";
                    break;
            }
        }
    }
}
