   M S B A M L   `   `   `  ����O  KGestorFinanceiro.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:GestorFinanceiro.WPFGestorFinanceiro.WPF  5   	   [2clr-namespace:GestorFinanceiro.WPF.Views.Controles$GestorFinanceiro.WPF.Views.Controles  5   	   %    GestorFinanceiro.WPF.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:GestorFinanceiro.WPF     5   	   H	controles2clr-namespace:GestorFinanceiro.WPF.Views.Controles     5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	      MaterialDesignBody#���   5
   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	   ���#F1F2F5  MaterialDesignFont#���  5   	    � Title$ 
MainWindow��5   	   $	��720��6   $
��1080��6)   .��5      )  #MaterialDesignThemes.Wpf.DialogHost     
Identifier$ 
RootDialog��6    .��5   
   �  � RowDefinitions 5      �� 5      $
��auto �6    �� 5      $��* �6    .+�5      #  MaterialDesignThemes.Wpf.Card  $��0��6"   $y�	Collapsed=�6/   .��5      �  � ColumnDefinitions 5      �� 5      $��* �6+   �� 5      $��* �6+   .+�5       �� $��0��5!      $
��LOGO��5"      $
��Bold"�5#      $��18(�5$      $��Center=�5%      $��10 0 0 0q�5&      �� 5(      $��1��5)       �� Orientation$ 
Horizontal=�5*      $��Center=�5+      $��Right=�5,      $��0q�5-      .+�5.      %  MaterialDesignThemes.Wpf.Badged     Badge$ 1��5/         BadgePlacementMode$ TopRight=�50      	   BadgeBackground
	 �  ��
   BadgeForeground

 �����$��Center=�53      $��0 0 15 0q�54      .��55      �� $��22��56   !   $��22��57   !   $��0q�58   !   $��0q�59   !   
������ .��5;   "   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Bell=�5<   %   ���#5f6368$��22��5>   %   $��22��5?   %   5@      5A      �� 5B      $��32��5C      $��32��5D      $��0q�5E      $��0 0 15 0q�5F      $��0q�5G      
������ .��5I        $ AccountCircle=�5J   !   ���#5f6368$��28��5L   !   $��28��5M   !   5N      5O      5P      5Q      � 5S      $��1��6    5T      �� 5U      $
��auto �6'   �� 5V      $��* �6'   .+�5Y      � $��0��6   ��5Z      �� 5[       �� 
TargetType" �6     �� Triggers 5\      �� 5]   "    �� Binding 6.   �� *
EstaLogado+ �� Value	 False6M   .a�5^   &   ��  �� Property � y� �� Value$ 	Collapsed=�6C   5_   #   5a      .+�5c      8   2GestorFinanceiro.WPF.Views.Controles.NavigationBar  5d      � 5f      $��1��6   .+�5g      � $��0��6    5h      �� 5i      $��* �6/   �� 5j      $	��300 �6/   .+�5m      �� $��0��5n      $��2��5o      $��15q�5q      ��5p      �� *CurrentViewModel+5r      �� 5t      $��1��5u      ���#F2F2F2$��1 0 0 0q�5w      $y�	Collapsed=�5x      ._�5y      �  5z   "   �� 5{   &   $��35 �64   �� 5|   &   $
��auto �64   �� 5}   &   $��* �64   .+�5�   "   � $��0��6'   ���#F2F2F2 5�   &   �� 5�   *   $��* �6;   �� 5�   *   $��* �6;   .+�5�   &   �� $��0��5�   )   $��	Mensagens��5�   )   $
��Bold"�5�   )   $��Center=�5�   )    �� Padding$ 5 0 0 0q�5�   )   �� 5�   &   $��1��5�   )    � ToolTip$ Fechar��5�   )   $��20��5�   )   $��20��5�   )   $��0q�5�   )   
������ 
������ $��Right=�5�   )   $��0 0 10 0q�5�   )   .��5�   *     $ Close=�6B   
���   �6O   5�   '   5�   #   �� 5�   "   $��1��6*   $��0q�67   .@�5�   &   �  5�   *   �� 5�   .   $��* �6?   �� 5�   .   $
��auto �6?   .+�5�   *   �� $��0��5�   -   $��0 0 10 0q�5�   -   $
��auto��5�   -   $	��Top=�5�   -   .+�5�   .   �� $'��!Boleto disponível ⋅ 29/05/2021��5�   1   $
��Bold"�5�   1   $��15(�5�   1   �� 5�   .   $R��LSeu boleto foi gerado com vencimento em 15/06/2021 e foi enviado por e-mail.��5�   1   $
��Wrap=�5�   1   $��0 5 0 5q�5�   1   �� 5�   .   $��0 0 10 0q�68   �� 5�   *   $�� ?�5�   -    �� TextDecorations$
 none{�5�   -   .�6D   Baixar boleto5�   +   5�   /   5�   +   �� 5�   *   $��1��5�   -   $��20��5�   -   $��20��5�   -   
������ 
������ $	��Top=�5�   -   $��0q�5�   -   .��5�   .     $ Close=�5�   1   
���   �5�   1   5�   +   5�   '   5�   #   5�      5�      5�      5�      5�      5�      5�      5�      