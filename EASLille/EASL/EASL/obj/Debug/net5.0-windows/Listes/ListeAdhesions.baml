   M S B A M L   `   `   `  ����?  ;EASL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:EASL.ListesEASL.Listes  5   	        EASL.Listes.ListeAdhesions   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:EASL.Listes     5   	     � Title$  ListeAdhesions��5   	   $	��450��6    $	��800��6-   .��5	      � ���	#FF292424 � ColumnDefinitions 5
   
   �� 5      $	��10* �6   �� 5      $
��271* �6   �� 5      $��8* �6   �� 5      $	��45* �6   �� 5      $��8* �6   �� 5      $	��45* �6   �� 5      $	��10* �6    � RowDefinitions 5   
   �� 5      $	��15* �6   �� 5      $	��58* �6   �� 5      $	��13* �6   �� 5      $	��58* �6   �� 5      $	��13* �6   �� 5      $	��58* �6   �� 5      $	��13* �6   �� 5      $	��58* �6   �� 5      $	��13* �6   �� 5      $	��58* �6   �� 5      $	��13* �6   �� 5      $	��48* �6   �� 5       $	��15* �6   .+�5$   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DgListeAdhesions��5$      ���	#FF292424   AutoGenerateColumns$ False��5%      $��13��6)   $��2��6;   $y�Visible=�6Q   $
��Bold"�6f   ���	#FF292424$	��650��6�   $
��Left=�6�   $��1��6�   $��1��6�      Columns 5)      0  *System.Windows.Controls.DataGridTextColumn  5*      ,  &System.Windows.Controls.DataGridColumn   Header$ 
IdAdhesion��6&   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   �� *
IdAdhesion+  5+      $ DateDebutAdhesion��6'    6B   �� *DateDebutAdhesion+  5,      $ DateFinAdhesion��6&    6?   �� *DateFinAdhesion+  5-      $ IdUtilisateur��6&    6=   �� *IdUtilisateur+51      �� 52   
   -   5         ��Name$ btnAjouterAdhesions��52      $��Ajouter��6.   $��4��6@   $��3��6Q   $��2��6x   $��1��6�   ���	#FFE86E34$
��Bold"�6�   �� 53   
   -   5        $ btnSupprimerAdhesions��53      $��	Supprimer��60   $��4��6D   $��5��6U   $��2��6{   $��1��6�   ���	#FFE86E34$
��Bold"�6�   �� 54   
   -   5        $ btnModifierAdhesions��54      $��Modifier��6/   $��4��6B   $��7��6S   $��2��6z   $��1��6�   ���	#FFE86E34$
��Bold"�6�   �� 55   
   -   5        $ btnRetourAdhesions��55      $��Retour��6-   $��4��6>   $��11��6O   $��2��6m   $��1��6�   ���	#FF4FF04F$
��Bold"�6�   56      57      