   M S B A M L   `   `   `  ����B  >WpfApp4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp4WpfApp4  5   	   ?$clr-namespace:WpfApp4.MVVM.ViewModelWpfApp4.MVVM.ViewModel  5   	       WpfApp4.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp4     5   	   :	viewmodel$clr-namespace:WpfApp4.MVVM.ViewModel     5   	   
������   � Title$  Project��5	   	   $	��600��6   $	��920��6&    � WindowStyle$
 None=�5
   	    � 
ResizeMode$ NoResize=�5   	    � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�5   	    � DataContext 5      *  $WpfApp4.MVVM.ViewModel.MainViewModel  5   
   .��5      �� ���#272537 �� CornerRadius$ 20��6"   ._�5   
   �  � ColumnDefinitions 5      �� 5      $	��200 �6#   �� 5       � RowDefinitions 5      �� 5      $��75 �6    �� 5      .+�5      �� $	��CEO��6   $��Center=�6#   $
��Left=�5       
�������$��22(�5!      $��20,0,0,0q�6"   �� 5#      $��1��6   .+�5$      	� $��Weather��6   $��50��60   
�������$��14(�5%         MenuButtonTheme#��[  5&      	 d� 	IsChecked$
	 TrueY�5'      ��5(      �� *homeViewCommand+	� 5)      $��Comic��6   $��50��6.   
�������$��14(�5*      #��[  5+      ��5,      �� *discoveryViewCommand+	� 5-      $��Bible��6   $��50��6.   
�������$��14(�5.      #��[  5/      ��50      �� *bibleViewCommand+54      �� 56      $	��250��6   $��40��57      $��Center=�58      $
��Left=�59      $��5q�5:      $��1��5;        ModernTextbox#��[ 5<      �� 5>      $��1��6   $��1��6*   $��10q�5?      ��5@      �� *CurrentView+5A      5E      5F      