   M S B A M L   `   `   `  ����O  KGestorFinanceiro.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:GestorFinanceiro.WPF.Views.Movimentacao'GestorFinanceiro.WPF.Views.Movimentacao  5      :    4GestorFinanceiro.WPF.Views.Movimentacao.ucFinanceiro   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Glocal5clr-namespace:GestorFinanceiro.WPF.Views.Movimentacao     5      b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5         MaterialDesignBody#���   5	      $��Regular"�5
      $��16(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5      .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   � $��0��6   .+�5      � $��5q�6    � ColumnDefinitions 5      �� 5      $��* �6'   �� 5      $
��auto �6'   �� 5      $
��auto �6'   .+�5!      �� $��0��5"      $��Valores em caixa��5#      $��Medium"�5$      $��18(�5%      $��Center=�5&      5'      5(      � 5*   
   $��1��6    5+      �� 5,      $
��auto �6#   �� 5-      $
��auto �6#   �� 5.      $
��auto �6#   .+�51      (  "System.Windows.Controls.DatePicker  $��0��52      $	��120��54      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Data inicial��55      $��5q�56       ( $MaterialDesignFloatingHintDatePicker#��[ 57         Text 53      �� *DataInicial+ �� StringFormat$ dd MMM yyyy��57        58      $��1��59      $	��120��5;      $ 
Data final��5<      $��5q�5=      #��[ 5>       5:      �� *	DataFinal+$ dd MMM yyyy��5>      �� 5@      $��2��5A      $��5q�5B      ���#496EF8
�������.��5D   $   Gerar5F      5G      &   System.Windows.Controls.DataGrid  5I   
   $��2��5J         AutoGenerateColumns$ False��5L         CanUserAddRows$ False��5M      ��5K      �� *FinanceiroValores+	 �� UpdateSourceTrigger$	 PropertyChanged=�
   Columns
 5N      0  *System.Windows.Controls.DataGridTextColumn  5O      ,  &System.Windows.Controls.DataGridColumn   Header$ Descrição��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 250 6V      
IsReadOnly$
 True��6b   1  +System.Windows.Controls.DataGridBoundColumn   Binding 68   �� *	Descricao+6b     5P      $ 
Valor (R$)��6%   $	 120 6X   $
 True��6d    69   �� *
PrecoCusto+6d     5Q      $ Desconto��6%   $	 120 6Y   $
 True��6e    67   �� *TotalDesconto+6e     5R      $ 
Quantidade��6%   $	 120 6X   $
 True��6d    69   �� *
Quantidade+6d     5S      $ 
Total (R$)��6%   $	 120 6Z   $
 True��6f    69   �� *TotalLiquido+6f   5U      �� 5W   
   $��3��5X       �� Orientation$ 
Horizontal=�5Y      $��Right=�5Z      .+�5[      �� $��VALOR TOTAL��5\      $��26(�5]      $	��180��5^      �� 5_      $��26(�5a      $��Right=�5b      ��5`      �� *
ValorTotal+$	 PropertyChanged=�$ {0:c}�� �� FallbackValue$
 0,00��5b      5c      5d      5e      