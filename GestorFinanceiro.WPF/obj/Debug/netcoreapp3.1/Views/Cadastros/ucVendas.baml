   M S B A M L   `   `   `  ����O  KGestorFinanceiro.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:GestorFinanceiro.WPF.Views.Cadastros$GestorFinanceiro.WPF.Views.Cadastros  5      [2clr-namespace:GestorFinanceiro.WPF.Views.Controles$GestorFinanceiro.WPF.Views.Controles  5      3    -GestorFinanceiro.WPF.Views.Cadastros.ucVendas   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Dlocal2clr-namespace:GestorFinanceiro.WPF.Views.Cadastros     5      Gcontrole2clr-namespace:GestorFinanceiro.WPF.Views.Controles     5      b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	         MaterialDesignBody#���   5
      $��Regular"�5      $��16(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5      .��5      � $��15q�6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   � $��0��6   .+�5      � $��5q�6    � ColumnDefinitions 5      �� 5      $��* �6'   �� 5      $
��auto �6'   �� 5      $
��auto �6'   .+�5"      �� $��0��5#      $��Vendas��5$      $��Medium"�5%      $��18(�5&      $��Center=�5'      �� 5(      $��1��5)       �� Orientation$ 
Horizontal=�5*      .+�5+      �� ���#496EF8���#496EF8$��10 0 0 0q�5.      .��5/      �� $ 
Horizontal=�6%   .+�50      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ ContentSave=�66   �� 51      $��Salvar��6(   $��5 0 0 0q�66   52      53      54      55      56      � 58   
   $��1��6    59      �� 5:      $��* �6#   �� 5;      $��* �6#   �� 5<      $��* �6#   �� 5=      $��* �6#    5?      �� 5@      $
��auto �6    �� 5A      $
��auto �6    �� 5B      $
��auto �6    �� 5C      $
��auto �6    .+�5F      6   0GestorFinanceiro.WPF.Views.Controles.TextProcura  $��0��5G      $��4��5H      $��0��5I         Hint$ Cliente��5J         Text 5K      �� *NomeCliente+ �� Mode$ TwoWay=�  5M      $��0��5N      $��4��5O      $��1��5P      $ Produto��5Q       5R      �� *NomeProduto+$ TwoWay=�	   Command	 5S      �� *ProcurarTabelaPrecoCommand+5U      &   System.Windows.Controls.DataGrid  5W   
   $��2��5X      
   AutoGenerateColumns$
 False��5Z         SelectionMode$ Extended=�5[         CanUserAddRows$ False��5\      ��5Y      �� *
Produtos+$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�   Columns 5]      0  *System.Windows.Controls.DataGridTextColumn  5^      ,  &System.Windows.Controls.DataGridColumn   Header$ Produto��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6V      
IsReadOnly$
 True��6`   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *NomeProduto+6`     5_      $ 
Quantidade��6%   $	 120 6X    69   �� *
Quantidade+6X     5`      $ Preço��6%   $	 120 6N   $
 True��6Z    64   �� *Preco+6Z     5a      $ Desconto��6%   $	 120 6Y    67   �� *TotalDesconto+6Y     5b      $ Total��6%   $	 120 6S   $
 True��6_    64   �� *
ValorTotal+6_   5d      � 5f   
   $��3��6   $��0 15 0 0q�6   .+�5g      �� $ 
Horizontal=�6   $��Right=�62   .+�5h      �� $��TOTAL VENDA��5i      $��26(�5j      $��Center=�5k      $��0 0 10 0q�5l      �� 5m      $��26(�5o       �� TextAlignment$ Right=�5p      $	��150��5q      ��5n      �� *TotalProdutos+ �� FallbackValue$
 0,00�� �� StringFormat$ {0:c}��$ PropertyChanged=�5q      5r      5s      5t      5u      