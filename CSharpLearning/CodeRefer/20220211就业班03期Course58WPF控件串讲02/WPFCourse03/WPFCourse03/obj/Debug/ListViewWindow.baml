   M S B A M L   `   `   `  ����F  BWPFCourse03, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WPFCourse03WPFCourse03  5   	        WPFCourse03.ListViewWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:WPFCourse03     5   	   -   5          � Title$  ListViewWindow��5   	   $	��450��6    $	��800��6-   .��5	      � .+�5
   
   �� -   5        $��
lvStudents��5
      $
��Left=�6%   $	��280��6@   $��	52,42,0,0q�6M   $	��Top=�6`   $	��539��6x    �� View 5      �� 5      .P�5      �� -   5        
colChk����5      �� 5      -   5        $��chkAll��5   '   $��全选��65    �� CellTemplate 5      �� 5      .R�5   "   �� $	��chk��6+    d� 	IsChecked 66   ��  �� ElementName$ chkAll�� �� Path$ 	IsChecked� �� Mode$ OneWay=�
 � Tag 6z   �� *StuId+5      5      �� 5      $��学号��6%    �� Width$ 60��6X   	 �� DisplayMemberBinding	 61   �� *StuId+6X   �� 5      $��姓名��6%   $ 80��61    5      �� 5      .R�5   "   �� $��1q�6)   
���2͚�
 �� CornerRadius$
 3��6W   ._�5   &   �� 
��� � �$��Center=�6\   ��60   �� *	StuName+6\   5   #   5      5       �� 5!      $��性别��6%   $ 60��61   	 6<   �� *Sex+ �� HeaderTemplate 5"      �� 5#      .R�5$   "   �� 
���  ��$��1q�6M   
���� ����6(   �� 6a   5%      5'      �� 5(      $��电话��6%   $	 150��61   	 6=   �� *Phone+�� 5)      $��修改��6%   $ 80��61    5*      �� 5+      .R�5,   "   �� $��修改��6)   $��40��66   $��25��6A   5-      5/      50      52      54      55      