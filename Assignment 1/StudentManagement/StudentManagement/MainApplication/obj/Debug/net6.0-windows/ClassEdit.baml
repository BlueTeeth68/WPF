   M S B A M L   `   `   `  ����J  FMainApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:MainApplicationMainApplication  5          MainApplication.ClassEdit   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      /localclr-namespace:MainApplication     5      -   5          � WindowStyle$
  None=�5	       � 
ResizeMode$ NoResize=�5
       � WindowStartupLocation$ CenterOwner=�5      
������  � AllowsTransparency$
 True��5      $	��400��5      $	��400��5      .��5      ��  �� CornerRadius$ 10��5   	   ���#7f95d8._�5   
   �  � RowDefinitions 5      �� 5      $��30 �5      �� 5      .+�5      �� -   5         ��Name$ btnClose��5         DeleteButton#��[  5      $
��Left=�5      $��	340,0,0,0q�5      $��30��5       $	��Top=�5!      �� 5"      $��1��5#      .+�5$      �� -   5         ��Name$
 lbId��5%       �� Left$ 61��5&      
	 �� Top$		 112��5'      $��12(�5(      $��Class Id��5)      $��60��5*      $��28��5+      
�������$
��Left=�5-      $��Center=�5.      �� 5/      -   5        
 ��Name$
 
txtClassId��50        InputTextBox#��[ 51      $
��Test��52      $	 139��53       �� TextWrapping$
 Wrap=�54      $		 115��55      $	��183��56      $��22��57       �� 
IsReadOnly$
 True��58      $
��Left=�59      $��Center=�5:       �� 
CaretBrush
 �   �5;      �� 5<      -   5        $ lbClassName��5=      $ 61��5>      $		 162��5?      $��12(�5@      $��
Class name��5A      $��74��5B      $��28��5C      
�������$
��Left=�5E      $��Center=�5F      �� 5G      -   5        $
 txtClassName��5H      #��[ 5I      $
��Test��5J      $	 139��5K      $
 Wrap=�5L      $		 165��5M      $	��183��5N      $��22��5O      $��Center=�5P      $	��Top=�5Q      
 �   �5R      �� 5U      -   5        $ btnSave��5V      $
��Save��5W      $	 138��5X      $		 218��5Y        
SaveButton#��[ 5Z      $��60��5[      $��26��5\      5]      5_      5`      5b      5c      