using ClassIsland.Core.Abstractions.Controls;
using ClassIsland.Core.Attributes;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
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

namespace EnhancedDateComponent
{
    [ComponentInfo(
    "3B1C189E-F85C-4233-9FC2-22734211ABC2",
    "更好的的日期",
    PackIconKind.CalendarOutline,
    "描述文本"
)]
    /// <summary>
    /// EnhancedDateCmpnt.xaml 的交互逻辑
    /// </summary>
    public partial class EnhancedDateCmpnt : ComponentBase<EnhancedDateCmpntSettings>
    {
        public EnhancedDateCmpnt()
        {
            InitializeComponent();
        }
    }
}
