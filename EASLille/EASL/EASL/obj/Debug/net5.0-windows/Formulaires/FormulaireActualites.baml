   M S B A M L   `   `   `  ����?  ;EASL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:EASL.FormulairesEASL.Formulaires  5   	   +    %EASL.Formulaires.FormulaireActualites   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:EASL.Formulaires     5   	     � Title$  FormulaireActualites��5   	   $	��450��6&   $	��800��63   .��5
   
   � ���	#FF292424 � ColumnDefinitions 5      �� 5      $��1* �6   �� 5      $��2* �6   �� 5      $��1* �6   �� 5      $��5* �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��2* �6   �� 5      $��1* �6   �� 5      $��2* �6   �� 5      $��1* �6   �� 5      $��2* �6   �� 5      $��1* �6   �� 5      $��2* �6   �� 5      $��1* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5       $��1* �6   .+�5#   
   �� -   5         ��Name$ labTitreFormulaire��5#      $��Titre��6-   $��1��6=   $��Center=�6J   $��1��6n   $
��Bold"�6~   $��16(�6�   $��3��6�   ���	#FFFBF5F56�   �� 5%   
   $��Titre��6   $��3��6    $��Center=�6-   $��1��6Q   $
��Bold"�6a   ���	#FFFBF5F56s   �� 5&   
   -   5         ��Name$ txbTitre��5&      $��3��6$   $�� ��61   $��Center=�69   $��3��6]   �� 5(   
   $��Contenu��6   $��5��6"   $��Center=�6/   $��1��6S   $
��Bold"�6c   ���	#FFFBF5F56u   �� 5)   
   -   5        $ 
txbContenu��5)      $��5��6&   $�� ��63   $��Center=�6;   $��3��6_   �� 5+   
   $��Date Affichage��6   $��7��6)   $��Center=�66   $��1��6Z   $
��Bold"�6j   ���	#FFFBF5F56|   (  "System.Windows.Controls.DatePicker  5,   
   -   5          Name$ dpDateAffichage��5,      $��7��6.      Text$  ��6;   $��Center=�6C   $��3��6g   $
��Bold"�6w   ���	#FFFBF5F56�   � 5/   
   $��11��6   $��1��6   $��3��6-    51      �� 52      $��2* �6#   �� 53      $��3* �6#   �� 54      $��2* �6#   �� 55      $��3* �6#   �� 56      $��2* �6#   .+�58      �� -   5         ��Name$ btn_Annuler��58      $��Annuler��6*   $��1��6<   $��1��6M   ���	#FFE86E34$
��Bold"�6�   �� 59      -   5        $ btn_Valider��59      $��Valider��6*   $��3��6<   $��1��6L   ���	#FF4FF04F$
��Bold"�6q   5:      5;      5<      