   M S B A M L   `   `   `  ����G  CModernDesign, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:ModernDesignModernDesign  5      I)clr-namespace:ModernDesign.MVVM.ViewModelModernDesign.MVVM.ViewModel  5          ModernDesign.MainWindow   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      ,localclr-namespace:ModernDesign     5      ?	viewModel)clr-namespace:ModernDesign.MVVM.ViewModel     5      $	��600��5
      $	��920��5        � WindowStyle$
  None=�5       � 
ResizeMode$ NoResize=�5      
������  � AllowsTransparency$
 True��5       � WindowStartupLocation$ CenterScreen=�5       � DataContext 5      /  )ModernDesign.MVVM.ViewModel.MainViewModel  5   
   .��5      �� ���#272537 �� CornerRadius$ 20��5   	   ._�5   
   �  � RowDefinitions 5      �� 5      $��75 �5      �� 5       � ColumnDefinitions 5      �� 5       $	��200 �5!      �� 5"      .+�5%      �� $��Elysian��5&      $��Center=�5'      $
��Left=�5(      
�������$��22(�5*      $��20,0,0,0q�5+      �� 5-      $��1��5.      .+�5/      	� $
��Home��50      $��50��51      
�������$��14(�53         MenuButtonTheme#��[  54       d� 	IsChecked$
 TrueY�55      ��56      �� *HomeViewCommand+	� 58      $��	Discovery��59      $��50��5:      
�������$��14(�5<      #��[  5=      ��5>      �� *DiscoveryViewCommand+	� 5@      $��Feature��5A      $��50��5B      
�������$��14(�5D      #��[  5E      5F      �� 5H      $��1��5I      $	��250��5J      $��40��5K      $��Center=�5L      $
��Left=�5M      $��5q�5N        ModernTextBox#��[ 5O      �� 5Q      $��1��5R      $��1��5S      $��10q�5T      ��5U      �� *CurrentView+5W      5Y      5Z      