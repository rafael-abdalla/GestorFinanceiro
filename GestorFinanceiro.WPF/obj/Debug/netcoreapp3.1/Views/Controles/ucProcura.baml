   M S B A M L   `   `   `  ����O  KGestorFinanceiro.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:GestorFinanceiro.WPF.Views.Controles$GestorFinanceiro.WPF.Views.Controles  5      4    .GestorFinanceiro.WPF.Views.Controles.ucProcura   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Dlocal2clr-namespace:GestorFinanceiro.WPF.Views.Controles     5      b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5         MaterialDesignBody#���   5	      $��Regular"�5
      $��16(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5      .��5      � $	��650��6   $	��450��6   $��10q�6$    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   .+�5      �� $��0��5      $��Procura��5       $��18(�5!      $��Medium"�5"      $��Center=�5#      $��10 0 0 0q�5$      �� 5&      $��1��5'      $��32��5(      $��32��5)      $��Right=�5*      $��Center=�5+      
������ $��0q�5-      $��0q�5.      )  #MaterialDesignThemes.Wpf.DialogHost   CloseDialogCommand#��Z 5/      .��50      �� $ ��/Resources/delete_16px.png��6   $��16��6<   $��16��6G   51      52      6   0GestorFinanceiro.WPF.Views.Controles.TextProcura  54   
   $��1��55         Hint$ Procura��56      $��	10 0 10 0q�58         Text 57      �� *TextoProcura+ �� Mode$ TwoWay=�58      &   System.Windows.Controls.DataGrid  5:   
   $��2��5;         AutoGenerateColumns$ False��5>      	   CanUserAddRows$	 False��5?      $��	10 0 10 0q�5@      ��5<      �� *
Resultados+
 �� UpdateSourceTrigger$
 PropertyChanged=� �� SelectedItem 5=      �� *	Selecao+   Columns 5A      0  *System.Windows.Controls.DataGridTextColumn  5B      ,  &System.Windows.Controls.DataGridColumn   Header$ Descrição��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6V      
IsReadOnly$
 True��6`   1  +System.Windows.Controls.DataGridBoundColumn   Binding 68   �� *	Descricao+6`   5D      �� 5F   
   $��3��5G      $��0 1 0 0q�5H      ���#e3e3e35I      �� 5K   
   $��3��5L       �� Orientation$ 
Horizontal=�5M      $��Right=�5N      .+�5O      �� #��Z 5P         MaterialDesignOutlinedButton#��[ 5Q      
����������#252423 � ToolTip$ 	Confirmar��5T      $��	Confirmar��5U      $��	0 10 5 10q�5V      5W      5X      5Y      