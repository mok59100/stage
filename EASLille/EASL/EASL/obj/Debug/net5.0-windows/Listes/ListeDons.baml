   M S B A M L   `   `   `  ����?  ;EASL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:EASL.ListesEASL.Listes  5   	       EASL.Listes.ListeDons   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:EASL.Listes     5   	     � Title$  	ListeDons��5   	   $	��450��6   $	��800��6(   .��5	      � ���	#FF292424 � ColumnDefinitions 5
   
   �� 5      $	��10* �6   �� 5      $
��271* �6   �� 5      $��8* �6   �� 5      $	��45* �6   �� 5      $��8* �6   �� 5      $	��45* �6   �� 5      $	��10* �6    � RowDefinitions 5   
   �� 5      $	��15* �6   �� 5      $	��58* �6   �� 5      $	��13* �6   �� 5      $	��58* �6   �� 5      $	��13* �6   �� 5      $	��58* �6   �� 5      $	��13* �6   �� 5      $	��58* �6   �� 5      $	��13* �6   �� 5      $	��58* �6   �� 5      $	��13* �6   �� 5      $	��48* �6   �� 5       $	��15* �6   .+�5$   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DgListeDons��5$      ���	#FF292424   AutoGenerateColumns$ False��5%      $��13��6)   $��2��6;   $��	-2,0,1,-3q�6P   $y�Visible=�6c   $
��Bold"�6x   ���	#FF292424$	��650��6�   $
��Left=�6�   $��1��6�   $��1��6�      Columns 5(      0  *System.Windows.Controls.DataGridTextColumn  5)      ,  &System.Windows.Controls.DataGridColumn   Header$ IdDon��6&   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *IdDon+  5*      $	 Nom��6'    64   �� *Nom+  5+      $ Prenom��6&    66   �� *Prenom+  5,      $ 
LibelleDon��6&    6:   �� *
LibelleDon+  5-      $ 
MontantDon��6&    6:   �� *
MontantDon+52      �� 53   
   -   5         ��Name$ btnAjouterDons��53      $��Ajouter��6)   $��4��6;   $��3��6L   $��2��6s   $��1��6�   ���	#FFE86E34$
��Bold"�6�   �� 54   
   -   5        $ btnSupprimerDons��54      $��	Supprimer��6+   $��4��6?   $��5��6P   $��2��6w   $��1��6�   ���	#FFE86E34$
��Bold"�6�   �� 55   
   -   5        $ btnModifierDons��55      $��Modifier��6*   $��4��6=   $��7��6N   $��2��6u   $��1��6�   ���	#FFE86E34$
��Bold"�6�   �� 56   
   -   5        $ btnRetourDons��56      $��Retour��6(   $��4��69   $��11��6J   $��2��6h   $��1��6}   ���	#FF4FF04F$
��Bold"�6�   57      58      