   M S B A M L   `   `   `  ����@  <VVW_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:VVW_1.Fenster.BackendVVW_1.Fenster.Backend  5   	   -    'VVW_1.Fenster.Backend.SpartenAktivieren   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:VVW_1.Fenster.Backend     5   	     � Title$.  ( Verein Konfigurieren Spartenaktivierung��5   	   $	��450��6:   $	��800��6G    � 	Resources 5	       �� 
TargetType �� Property �� Value��%Q   '��       �� 5
   
   " ��6   .�5      ��  � ��$ 7q�6'   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $
��178* �6   �� 5      $
��172* �6   �� 5      $	��69* �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ dgSpartenInaktive��5         AutoGenerateColumns .  ��6N   �� 	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 ID��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   ��  �� Path$ spa_id�  5      $
 Spartenbezeichnung��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$	 400 6E    6Q   �� $ spa_text�4  .System.Windows.Controls.DataGridCheckBoxColumn  5      $
 Aktiv setzen��6-    6C   �� $ spa_akt�5      �� 5      -   5         ��Name$ btnUebernehmen��5      $	��30 ��6J   .��6X   Auswahl übernehmen6l   5      �� 5   
   $��1��6   $ 
Horizontal=�6"   .+�5         -   5        $ dgSpartenAktive��5        .  	 5!        5"      $
 ID��6)    65   �� $ spa_id�  5#      $
 Spartenbezeichnung��6)    6E   �� $ spa_text�  5$      $
 Aktiv setzen��6-    6C   �� $ spa_akt�5&      5'      5(      5)      