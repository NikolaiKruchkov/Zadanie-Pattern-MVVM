   M S B A M L   `   `   `  ����G  CPattern MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Pattern_MVVMPattern_MVVM  5   	   A%clr-namespace:Pattern_MVVM.ViewModelsPattern_MVVM.ViewModels  5   	       Pattern_MVVM.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Pattern_MVVM     5   	   4vm%clr-namespace:Pattern_MVVM.ViewModels     5   	     � Title$  
MainWindow��5	   	   $	��300��6   $	��400��6)    � DataContext 5
      1  +Pattern_MVVM.ViewModels.MainWindowViewModel  5   
   .��5      �� .+�5   
   �� $7��1Введите радиус окружности:��6   �� 5   
   ��6   ��  �� Path$ Radius��� 5   
   $:��4Рассчитать длину окружности��6   ��67   �� $ PoschitaemDlinu��� 5   
   $1��+Длина окружности равна:��6   �� 5   
   ��6   �� $ Dlina��� 5   
   $?��9Рассчитать  площадь окружности��6   ��6:   �� $ PoschitaemPloshad��� 5   
   $5��/Площадь окружности равна:��6   �� 5   
   ��6   �� $ Ploshad�5      5      