   M S B A M L   `   `   `  ����M  IMiniTotalCommander, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:MiniTotalCommanderMiniTotalCommander  5   	   K*clr-namespace:MiniTotalCommander.ViewModelMiniTotalCommander.ViewModel  5   	   A%clr-namespace:MiniTotalCommander.ViewMiniTotalCommander.View  5   	   #    MiniTotalCommander.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:MiniTotalCommander     5   	   9vm*clr-namespace:MiniTotalCommander.ViewModel     5   	   6view%clr-namespace:MiniTotalCommander.View     5   	     � Title$  
MainWindow��5
   	   $	��700��6   $	��650��6)    � DataContext 5      0  *MiniTotalCommander.ViewModel.MainViewModel  5   
   .��5      �  � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   .+�5   
   %   MiniTotalCommander.View.PanelTC  $��0��6      CurrentPath 5      ��  �� Path$ Left.CurrentPath� �� Mode$ TwoWay=�   Drives	 5      �� $ Left.Drives�$ TwoWay=�
   Paths	 5      �� $ 
Left.Paths�$ TwoWay=�
   CurrentDrive 5      �� $ Left.CurrentDrive�$ TwoWay=�	   SelectedPath	 5      �� $ Left.SelectedPath�$ TwoWay=�
   DoubleClickCommand
 5      �� $ Left.DoubleClickcommand�$ TwoWay=�  5   
   $��1��6    5      �� $ Right.CurrentPath�$ TwoWay=�	 5      �� $ Right.Drives�$ TwoWay=�
	 5       �� $ Right.Paths�$ TwoWay=�
 5!      �� $ Right.CurrentDrive�$ TwoWay=�	 5"      �� $ Right.SelectedPath�$ TwoWay=�
 5#      �� $ Right.DoubleClickcommand�$ TwoWay=��� 5(   
   $
��Left=�6   $��Bottom=�6,   $��80��6G   $��25��6R   $��Copy >> ��6^   $��12(�6q   $��Arial)�6   $��2��6�   $��3��6�   ��6�   �� *Copy+5)      5*      