////$(document).ready(function () {
////    $('.select2').select2();
////    //Datemask dd/mm/yyyy
////    $('#datemask').inputmask('dd/mm/yyyy', { 'placeholder': 'dd/mm/yyyy' });
////    //Datemask2 mm/dd/yyyy
////    $('#datemask2').inputmask('mm/dd/yyyy', { 'placeholder': 'mm/dd/yyyy' });
////    //Money Euro
////    $('[data-mask]').inputmask();
////});

$("input[tipo= 'data']").inputmask('dd/mm/yyyy', { 'placeholder': 'dd/mm/aaaa' });
$("input[tipo= 'hora']").inputmask('hh:mm', { 'placeholder': 'hh:mm' });

//preenche o cámpo de hidden com o valor do select 
$("#selectEventoPerfil").change(function () {
    $("#IDEventoPerfil").val($(this).val());
});

//document.getElementById("outra_data").addEventListener("onchange", mascaraData(document.getElementById("outra_data").innerHTML));

//function mascaraData(val) {
//    var pass = val.value;
//    var expr = /[0123456789]/;

//    for (i = 0; i < pass.length; i++) {
//        // charAt -> retorna o caractere posicionado no índice especificado
//        var lchar = val.value.charAt(i);
//        var nchar = val.value.charAt(i + 1);

//        if (i == 0) {
//            // search -> retorna um valor inteiro, indicando a posição do inicio da primeira
//            // ocorrência de expReg dentro de instStr. Se nenhuma ocorrencia for encontrada o método retornara -1
//            // instStr.search(expReg);
//            if ((lchar.search(expr) != 0) || (lchar > 3)) {
//                val.value = "";
//            }

//        } else if (i == 1) {

//            if (lchar.search(expr) != 0) {
//                // substring(indice1,indice2)
//                // indice1, indice2 -> será usado para delimitar a string
//                var tst1 = val.value.substring(0, (i));
//                val.value = tst1;
//                continue;
//            }

//            if ((nchar != '/') && (nchar != '')) {
//                var tst1 = val.value.substring(0, (i) + 1);

//                if (nchar.search(expr) != 0)
//                    var tst2 = val.value.substring(i + 2, pass.length);
//                else
//                    var tst2 = val.value.substring(i + 1, pass.length);

//                val.value = tst1 + '/' + tst2;
//            }

//        } else if (i == 4) {

//            if (lchar.search(expr) != 0) {
//                var tst1 = val.value.substring(0, (i));
//                val.value = tst1;
//                continue;
//            }

//            if ((nchar != '/') && (nchar != '')) {
//                var tst1 = val.value.substring(0, (i) + 1);

//                if (nchar.search(expr) != 0)
//                    var tst2 = val.value.substring(i + 2, pass.length);
//                else
//                    var tst2 = val.value.substring(i + 1, pass.length);

//                val.value = tst1 + '/' + tst2;
//            }
//        }

//        if (i >= 6) {
//            if (lchar.search(expr) != 0) {
//                var tst1 = val.value.substring(0, (i));
//                val.value = tst1;
//            }
//        }
//    }

//    if (pass.length > 10)
//        val.value = val.value.substring(0, 10);
//    return true;
//}