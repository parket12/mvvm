   M S B A M L   `   `   `  ����E  AMVVMVMVMVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:MVVMVMVMVM.ViewModelsMVVMVMVMVM.ViewModels  5   	   !    MVVMVMVMVM.Views.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :
viewModels#clr-namespace:MVVMVMVMVM.ViewModels     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � DataContext 5	      )   #MVVMVMVMVM.ViewModels.MainViewModel  5
   
   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��Enter Amount:��6   $��0��6)   $��Center=�66   �� 5   
   $��0��67   $��1��6D   $��5q�6T   ��6   �� *Amount+ �� Mode$ TwoWay=�6T   �� 5   
   $��Enter Exchange Rate:��6   $��1��60   $��Center=�6=   �� 5    
   $��1��6=   $��1��6J   $��5q�6Z   ��6   �� *ExchangeRate+$ TwoWay=�6Z   �� 5"   
   $��Convert��6   $��2��6F   $��2��6S   $��5q�6g   ��6#   �� *ConvertCommand+6g   �� 5$   
   $��Result:��6   $��3��6#   $��5q�60   $��Center=�6;   �� 5%   
    �� 
IsReadOnly$
 True��6*   $��3��6<   $��1��6I   $��5q�6Y   ��6   �� *Result+6Y   �� 5'   
   $��Select Currency��6   $��4��6\   $��2��6i   $��5q�6}   ��6+   �� *OpenCurrencySelectionCommand+6}   5(      5)      