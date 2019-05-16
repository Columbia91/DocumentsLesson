using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Xps.Packaging;

namespace DocumentsLesson
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();

            var xpsPath = openFileDialog.FileName;

            using(var xpsDocument = new XpsDocument(xpsPath, FileAccess.Read))
            {
                documentViewer.Document = xpsDocument.GetFixedDocumentSequence(); // загрузит последовательность
            }
        }
    }
}
/*<<!--FlowDocumentReader>
        <FlowDocument>
            <Section>
                <BlockUIContainer>
                    <Image Width="400" Source="https://image.jimcdn.com/app/cms/image/transf/none/path/sf278732f8691ebec/image/i864c0c57bdbcce75/version/1339107113/image.jpg"/>
                </BlockUIContainer>
            </Section>
            <Paragraph>
                <Span>
                    <Bold FontSize="42" FontFamily="Comic Sans MS" Foreground="Red">Ж</Bold>или-были старик со старухой</Span>
            </Paragraph>
        </FlowDocument>
    </FlowDocumentReader>-->*/
