/* 
 * Author : KAivan Alimohammadi;
 * Created By : NetBeans IDE  v-7.3.1;
 */
$(document).ready(function(){
    
    $('#chk').on("change",function(){
        
      if(this.checked==true)
      {
          $('#row').css({'display':'table-row'});
      }
      else
          {
              $('#row').css({'display':'none'});
          }
        
    });
});

