   M S B A M L   `   `   `  ����@  <VVW_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:VVW_1.FensterVVW_1.Fenster  5   	       VVW_1.Fenster.Master   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:VVW_1.Fenster     5   	     � Title$9  3Willkommen beim super coolen verwalten von Vereinen��5   	   $	��768��6E   $
��1280��6R      FensterSchrift#���   5	   	   $��16(�67   $
��Bold"�6E     Schriftfarbe#���  5
   	    � WindowStartupLocation$ CenterScreen=�65   ��5      �� 5   
    �� Color# � ��6    � 	Resources 5       �� 
TargetType �� Property �� Value  FrameButtonStyl �� 
TargetType A�Name��%  '��       &	 F     �� 5   
   " ��6   .�5      ��  � ��# �  6+   5      �� 5   
   " ��6(   .�5      ��  �@�OverridesDefaultStyle . 66   �� 5       � �� 5      �� 5      " ��6&   .R�5      � .+�5      A� $ Ellipse��6&   $��1��5      $��36��5      $��36��5      5      5      5       5"      5#      5$      .��5%      � 	 � RowDefinitions	 5&   
   �� 5'      $
��124* �6   �� 5(      $
��527* �6   �� 5)      $	��86* �6   .+�5+   
   �� -   5        $��spHeader��5+   3   $��0��6   $��0��6#   $��Center=�6C   .+�5,      � $
��1280��6   $	��124��6    
 � ColumnDefinitions
 5-      �� 5.      $
��300* �6'   �� 5/      $
��600* �6'   �� 50      $
��300* �6'   .+�52      �� -   5        $��spLinksHeader��52   6    �� Orientation$ 
Horizontal=�6   $��0��6K   $��0��6[   .+�53      �� -   5        $��spLinksLinksHeader��53   8   $ Vertical=�6!   .+�54      �� -   5        $��chkMitgl��54   #   $��Mitglied��63   $��
10,10,10,5q�6F   6\   �� 55      -   5        $��
chkSponsor��55   #   $��Sponsor��65   $
��10,5q�6G   6W   �� 56      -   5        $��
chkSpender��56   #   $��Spender��65   $
��10,5q�6G   6W   �� 57      -   5        $��	chkMitarb��57   #   $��Mitarbeiter��64   $
��10,5q�6J   6Z   58      59      �� 5:      -   5        $��spMittelHeader��5:   6   $ 
Horizontal=�6   $��1��6L   $��0��6\   $��Center=�5;      $��Center=�68   .+�5<      �� -	   5        $��lblNameMitgl��5<      $��25(�60   6A   5=      �� 5>      -
   5        $��spRechtsHeader��5>   6   $ 
Horizontal=�6   $��2��6L   $��0��6\   $��Center=�5?      $��Center=�68   .+�5@      �� -   5        $��imgVLogo��5@       $ ��/Resources/zdms_farbig.jpg��60   $	��100��6T   $	��250��5A       $
��Fill=�6,   5B      5E      5G       � 5I   
   -   5        $��	frmSeiten��5I      $��1��6!   $��0��6.   $��3q�6>     � NavigationUIVisibility$ Visible=�6I   6l   �� 5K   
   -   5        $��spFoot��5K   K   $��2��6   $��0��6"   $ 
Horizontal=�62   $��3q�6Y   $��Right=�5L      $��Center=�61   .+�5M      �� -   5        $��btnVorgaenger��5M       $��5q�6   $�� << zurück ��65   {�.  6�   �� 5N      -   5        $��btnVor��5N       $��5q�6   $�� weiter >> ��6C   6b   5O      5P      5Q      