﻿Public Class ClassQestions

    Dim data As String() = {"one", "two", "three", "four"}

    Public qstionsArr = New String(,) {
{"0", "txt", "alghaz", "شيء كلما زاد نقص؟", "الحفرة", "العمر", "الطريق", "المسافة", "2"},
{"1", "txt", "tarikh", "ما هي أرشليم حالياً ؟", "بغداد", "القدس", "الخليل", "غزة", "2"},
{"2", "txt", "din", "من أول من تكنى بأمير المؤمنين ؟", "عثمان بن عفان", "عمر بن الخطاب", "علي بن ابي طالب", "أبي بكر الصديق", "2"},
{"3", "txt", "taqafa", "من أول إمرأة حصلت على جائزة نوبل؟", "إيرين كوري", "ماري كوري", "ماريا ماير", "دونا ستريكلاند", "2"},
{"4", "txt", "tarikh", " ما هو أقدم الخطوط العربية؟", "الخط الكوفي", "خط النسخ", "خط الثلث", "الخط المغربي", "1"},
{"5", "txt", "taqafa", " متى تم عقد صلح الحديبية؟", "قبل الهجرة", "3 هجرية", "6 هجرية", "10 هجرية", "3"},
{"6", "txt", "ilm", "كم سعة حرارية في 25 حبة من الفستق ؟", "55 سعة حرارية", "180 سعة حرارية", "98 سعة حرارية", "15 سعة حرارية", "3"},
{"9", "txt", "din", " ما هي أخر الخلافات الإسلامية؟", "الخلافة العثمانية", "الخلافة الاموية", "الخلافة العباسية", "الخلافة الفاطمية", "1"},
{"10", "txt", "taqafa", "ماذا تعني الكلمة الأمازيغية (آرياز)", "امرأة", "رجل", "ولد", "بنت", "2"},
{"11", "txt", "ilm", "العقدة ؟", "هي قياس سرعة الريح", "هي قياس سرعة البواخر", "هي قياس سرعة الطائرات", "هي قياس سرعة الصواريخ", "2"},
{"12", "txt", "din", "أي السور التي ذُكر فيها البعوض؟", "سورة المائدة", "سورة النمل", "سورة البقرة", "سورة النحل", "3"},
{"13", "txt", "din", "ما معنى الدلوك ؟", "طلوع الشمس", "شروق الشمس", "زوال الشمس", "غروب الشمس", "3"},
{"14", "txt", "din", " ما هي أطول آيات القرآن الكريم؟", "آية الدين", "آية الكرسي", "اية الارث", "اية الحجاب", "1"},
{"15", "txt", "sport", "على ماذا أطلق الفن النبيل ؟", "الملاكمة", "المصارعة الحرة", "المسرح", "التمثيل", "1"},
{"16", "txt", "awasim", "ما هي عاصمة هولندا ؟", "امستردام", "كوالا لامبور", "كوبنهاغن", "نيودلهي", "1"},
{"17", "txt", "taqafa", "كم يبلغ متوسط عمر النعامة؟", "23 عامًا", "24 عامًا", "25 عامًا", "26 عامًا", "4"},
{"18", "txt", "taqafa", " ما هي أكبر الجزر الآسيوية؟", "أرخبيلات آسيا", "جزر ماليزيا", "جزر الصين‏", "جزيرة بورنيو", "4"},
{"19", "txt", "taqafa", "ماذا يعني إسم (خديجة) ؟", "التي ولدت 7 أشهر", "التي ولدت 6 أشهر", "التي ولدت 8 أشهر", "لا احد من الخيارات", "1"},
{"20", "txt", "din", "أين ذكر السيف في القرآن  ؟", "البقرة", "الأنفال", "الأحزاب", "لم يذكر", "4"},
{"21", "txt", "alghaz", "أنت تقود طائرة مسافراً من لندن إلى برلين لنقل فريق كرة القدم بقيادة اللاعب روني، ما هو اسم الطيّار؟", "روني", "طيار", "أنا", "إسمي", "4"},
{"22", "txt", "taqafa", " ما هي أصغر دولة العالم في المساحة؟", "مالطا", "البحرين", "تونس", "الفاتيكان", "4"},
{"23", "txt", "amma", "ما إسم منظمة الدول المصدرة للبترول؟", "أنغولا", "فيينا", "أفريقيا", "أوبك", "4"},
{"24", "txt", "din", "كم سجدة بالقران الكريم ؟", "10", "25", "14", "30", "3"},
{"25", "txt", "sport", "متى تأسست رياضه كرة السله ؟", "1891 م ", "1890 م ", "1882 م ", "1878 م ", "2"},
{"26", "txt", "awasim", "عاصمة الدوله العباسية ؟", "بغداد", "وليلي", "حلب", "القاهرة", "1"},
{"27", "txt", "amma", "من الذي إكتشف أمريكا؟", "أمريكو فيسبوتشي", "ابن بطوطة", "كولمبس", "ماجلان", "3"},
{"28", "txt", "din", " مم خلق كل شيء حي؟", "من الماء", "من التراب", "من الهواء", "من النور", "1"},
{"29", "txt", "din", " بطل أنمي ون بيس ؟", "شانكس", "لوفي", "زورو", "سانجي", "2"},
{"30", "txt", "amma", " أين تقع مدينة سوسة؟", "تونس", "الجزائر", "المغرب", "مصر", "1"},
{"31", "txt", "din", "كم سورة تبدأ بــ الحمد لله", "3 سور", "5 سور", "4 سور", "6 سور", "2"},
{"32", "txt", "sport", "كم عدد الحفر التي في لعبة الغولف؟", "12", "9", "18", "20", "3"},
{"33", "txt", "alghaz", "1000 أضف إليها 40. أضف الآن 1000 آخر . أضف الآن 30أضف 1000 آخر . أضف الآن 20. أضف الآن 1000 آخر أضف الآن 10. ما هو المجموع؟", "5000", "5100", "4100", "4000", "3"},
{"34", "txt", "ilm", "كم تساوي ميجا هيرتز ؟", "ترليون عملة في الثانية", "مليار عملية في الثانية", "ألف عملية في الثانية", "مليون عملية في الثانية", "4"},
{"35", "txt", "english", "Which word is a compound word?", "doors", "bells", "doorbell", "finger", "3"},
{"36", "txt", "amma", " أكبر خليج في العالم ؟ ", "الخليج المكسيكي", "الخليج العربي", "خليج كاليفورنيا", "خليج الأسد", "1"},
{"37", "txt", "english", "? what", "ماذا؟", "لماذا؟ ", "كيف؟ ", "لمن ؟ ", "1"},
{"38", "txt", "sport", "ما هي أول بلد عزفت النشيد الوطني؟", "إيطاليا", "ألمانيا", "تونس", "الولايات المتحدة", "4"},
{"39", "txt", "alghaz", " كلمة اسبانية Ciudad ماذا تعني ؟", "دولة", "مدينة", "قرية", "مقاطعة", "2"},
{"40", "txt", "taqafa", "من القائل :كن عظيما ودودا ، قبل أن تكون عظاما ودودا", "عائض القرني", "احمد الشقيري", "طارق السويدان", "الشعراوي", "4"},
{"41", "txt", "ilm", "ما هو الشيء الأسرع من الضوء؟", "الصوت", "النيزك", "الريح", "لا يوجد", "4"},
{"42", "txt", "sport", "ما معنى كلمة الإلتراس ؟", "الشماريخ", "المتطفلين", "المشجعين", "المتطرفين", "4"},
{"43", "txt", "amma", "أحد الفنون ليست من الفنون السبعة ؟", "فن الرسم", "فن النحت", "الفن التشكيلي", "فن التلوين", "3"},
{"44", "txt", "tarikh", "مكتشف المغناطيس ؟", "الرومان", "الهندوسيون", "المايا", "الاغريقيون", "1"},
{"45", "txt", "taqafa", " ماذا تعني كلمة بابل؟", "أرض فلسطين", "بلاد العجم", "بلاد الصوف", "القدس", "3"},
{"47", "txt", "amma", "أغلى سائل بالعالم ؟", "الدم الأزرق", "دم الإنسان", "سم الأفعى", "سم العقرب", "4"},
{"48", "txt", "ilm", "أحد المجالات لا تمنح فيها جائزة نوبل ؟", "الفيزياء", "الطب", "الآثار", "الفيسيولوجيا", "3"},
{"49", "txt", "tarikh", "كم استمرت الخلافة العثمانية؟", "300 سنة", "400 سنة", "500 سنة", "600 سنة", "2"},
{"51", "txt", "din", " أي السور في القرآن تُسمى بأم الكتاب؟", "سورة البقرة", "سورة الإخلاص", "سورة الفاتحة", "سورة يس", "3"},
{"52", "txt", "sport", "ﻣﻦ ﺃﻭﻝ ﻣﻦ ﺭﻛﺐ ﺍﻟﺨﻴﻞ ؟", "موسى عليه السلام", "إبراهيم عليه السلام", "يوسف عليه السلام", "إسماعيل عليه السلام", "4"},
{"54", "txt", "ilm", "ماهو علم السيتولوجيا ؟", "علم الانسان", "علم الجبر", "علم الأجنة", "علم الخلايا", "4"},
{"55", "txt", "amma", " الرسام الذي رسم لوحة الموناليزا ؟", "جورج سورا", "تشارلز", "هنري روسو", "دافنشي", "4"},
{"56", "txt", "amma", "مدينة تلقب بـ مدينة الضباب", "بولندا", "أمستردام", "لندن", "سان فرانسيسكو", "3"},
{"59", "txt", "amma", "من الملقب بـ أبو علم الحاسوب ؟", "باسكال", "الخوارزمي", "ابن الهيثم", "إسحاق نيوتن", "2"},
{"61", "txt", "taqafa", "ما أصل كلمة أطلس؟", "يوناني", "رومانية", "إغريقية", "فينقية", "1"},
{"62", "txt", "taqafa", " ما هو نظام الحكم في دولة اليابان؟", "نظام  إمبراطوري", "نظام ملكي", "نظام اتحادي", "نظام جمهوري", "1"},
{"63", "txt", "taqafa", " ما أطول أنهار أوروبا؟", "فولغا", "نهر الأورال", "الدانوب", "نهر بيلايا", "3"},
{"64", "txt", "taqafa", "أي المدن تُعرف بمدينة الشمس؟", "أتينا", "اسطنبول", "بعلبك", "روما", "3"},
{"65", "txt", "ilm", "بمَ يتخصص علم الجيولوجيا؟", "بدراسة الطبيعة", "بدراسة الهواء", "بدراسة المادة", "بدراسة الأرض", "4"},
{"66", "txt", "din", "اسم السورة رقم 12 من سور القرآن ؟", "إبراهيم", "يونس", "هود", "يوسف", "4"},
{"67", "txt", "amma", "أين توجد شلالات نياجارا", "المكسيك", "البرازيل", "أمريكا", "الصين", "3"},
{"68", "txt", "tarikh", "مؤلف كتاب (زاد المعاد)", "ابن القيم الجوزية", "ابن الجوزي", "ابن تيمية", "ابن كثير", "1"},
{"69", "txt", "tarikh", "أطلال إيوان كسرى تقع في ؟", "تبريز", "شيراز", "المدائن", "الحيرة", "3"},
{"70", "txt", "amma", "مماذا مصنوع تمثال الحرية ؟", "الفضة", "النحاس", "الحديد", "الالمنيوم", "2"},
{"71", "txt", "alghaz", "إذا كنت في سباق. و تجاوزت الشخص الأخير. فماذا سيكون ترتيبك ؟", "الاول", "الثاني", "قبل الاخير", "الاخير ", "4"},
{"72", "txt", "din", "من الملقب بتقي الدين ؟", "ابن تيمية", "احمد بن حنبل", "الشافعي", "الحنفي", "1"},
{"73", "txt", "taqafa", " بمَ يُسمى بيت الدجاج؟", "كوخ", "قن", "عش", "حظيرة", "2"},
{"74", "txt", "din", "مؤلف كتاب رياض الصالحين ؟", "ابن تيتمية", "ابن القيم الجوزي", "البوني", "النووي", "4"},
{"75", "txt", "sport", "أين سرق كأس العالم لأول مرة ؟", "فرنسا", "المكسيك", "الارجنتين", "انجلترا", "4"},
{"76", "txt", "amma", "معنى إسم دولة إسبانيا ؟", "بلد الأرانب", "بلد الخيول", "بلاد النمور", "لا احد من الخيارات", "1"},
{"77", "txt", "din", "أول من آمن بمحمد صلى الله عليه وسلم ؟", "أمنا عائشة", "أبي بكر الصديق", "أمنا خديجة", "زيد بن حارثة", "3"},
{"78", "txt", "amma", "أحد هذه المدن ليست في تايلاند ؟", "بانكوك", "شنغماي", "بوكيت", "بانغي", "4"},
{"79", "txt", "taqafa", "من الذي اخترع المصباح الكهربائي؟", "توماس أديسون", "انشتاين", "نيوتن", "جيمس واط", "1"},
{"80", "txt", "taqafa", " كم عدد الالوان الس في قوس قزح؟", "5", "7", "11", "12", "2"},
{"81", "txt", "taqafa", " ما هو أطول أنهار آسيا؟", "نهر الأردن", "اليانجستي", "نهر سيحون", "نهر جيحون", "2"},
{"82", "txt", "tarikh", "ظهور أول فيلم زومبي ؟", "سنة 1968", "سنة 1980", "سنة 1995", "سنة 1931", "1"},
{"83", "txt", "english", "What day is it today", "ما هو الشهر؟", "ما هو السنة ؟", "ما هو الاسبوع ؟", "ما هو اليوم ؟", "4"},
{"84", "txt", "ilm", "ما هو أقدم العلوم ؟", "علم الفلك", "علم الرمل", "علم الرياضيات", "علم النجوم", "1"},
{"85", "txt", "taqafa", "من القائل :الشخص الواثق بنفسه له ضحكة تختلف على الآخرين", "عائض القرني", "عمرو خالد", "ابراهيم الفقي", "لا احد منهم", "3"},
{"86", "txt", "taqafa", "ما هو المراد من كلمة ثكلتك أمك؟", "ضيعتك أمك", "فقدان المرأة ولده", "كلمة لا يراد بها حقيقتها", "فقدتك أمك", "3"},
{"87", "txt", "din", " كم يبلغ عدد أبناء الرسول محمد صلى الله عليه وسلم؟", "3 أبناء", "5 أبناء", "ليس له أبناء", "7 أبناء", "4"},
{"88", "txt", "sport", " من هو أول الفرق العربية التي تأهلت لكأس العالم؟", "مصر عام 1934م", "تونس عام 1935م", "الجزائر عام 1936م", "المغرب عام 1937م", "1"},
{"89", "txt", "sport", "يتكون فريق كرة السلة من ... ؟", "5 لاعبين", "7 لاعبين", "6 لاعبين", "4لاعبين", "1"},
{"90", "txt", "taqafa", " ما هو أثقل الحيوانات بالعالم؟", "الفيل", "الحوت الأزرق.", "القرش", "الأسد", "2"},
{"91", "txt", "alghaz", "بماذا يمتحن الذهب ؟", "بالمرأة", "بالرجل", "بالماء", "بالنار", "4"},
{"92", "txt", "tarikh", "في أي سنة هجرية نحن حاليا ؟", "1436 هـ", "1445 هـ", "1435 هـ", "1441 هـ", "4"},
{"93", "txt", "taqafa", " ما هي أكثر السلع تداولًا بالعالم؟", "النفط الخام", "الذهب", "السيارات", "القمح", "3"},
{"94", "txt", "tarikh", "مخترع الآلة الحاسبة ؟", "ماركوني", "باسكال", "وات", "باكريل", "2"},
{"95", "txt", "amma", "ما هي الدولة التي اشتهرت بالسوشي؟", "ايطاليا", "روسيا", "اليابان", "الصين", "3"},
{"96", "txt", "sport", "2 + 2 x 8 ÷ 8 = ?", "4", "16", "40", "80", "1"},
{"97", "txt", "din", "عنصر ليس من العناصر الأربع ؟", "الحديد", "النار", "التراب", "الماء", "1"},
{"98", "txt", "amma", "إسم بيت الدجاج ؟", "زريبة", "جحر", "قن", "كوخ", "3"},
{"99", "txt", "din", "من رقم القرآن ؟", "الحجاج بن يوسف", "عمر بن الخطاب", "عمر بن عبد العزيز", "عثمان بن عفان", "1"},
{"100", "txt", "amma", "أين يوجد سوق العفاريت ؟", "ليبيا", "مصر", "تونس", "المغرب", "4"},
{"101", "txt", "ilm", "7 - 3 x 2 = ?", "1", "6", "8", "18", "1"},
{"102", "txt", "amma", "من هم أشد الناس عداوة للمسلمين ؟", "اليهود", "المسيحيين", "البوديون", "الهندوسيون", "1"},
{"104", "txt", "tarikh", "أول صيدلية تم إنشاؤها ؟", "في بلاد اليهود", "في بلاد الهند", "في بلاد المسلمين", "في بلاد الصين", "3"},
{"105", "txt", "amma", " ما أسرع المخلوقات البحرية؟", "سمك التونة", "الحوت الأزرق", "القرش", "الدلفين", "1"},
{"106", "txt", "amma", "غاز يستخدم لإطفاء الحرائق ؟", "الهدروجين", "ثاني أوكسيد الكربون", "الأوكسجين", "البوتان", "2"},
{"107", "txt", "taqafa", "من القائل :وليت الذي بيني وبينك عامر *** وبيني وبين العالمين خراب", "رابعة العدوية", "الشافعي", "الخنساء", "المتنبي", "1"},
{"108", "txt", "amma", "ما هي أصغر دولة في العالم ؟", "تونس", "البحرين", "الفاتيكان", "المكسيك", "3"},
{"109", "txt", "amma", "من القائل لولا أن الموت أتاني لجعلت كل الدول الأوروبية إسلامية ", "صلاح الدين الايوبي", "طارق بن زياد", "عمر المختار", "عمرو بن العاص", "1"},
{"110", "txt", "alghaz", "دولة يمنع فيها شرب الكحول أمام البقر ؟", "تايلاند", "الهند", "أيرلاندا", "إنجلترا", "2"},
{"111", "txt", "taqafa", "في أي مكان توجد حاسة الشم بالثعبان؟", "اللسان", "الفم", "الأنف", "العينان", "1"},
{"112", "txt", "ilm", "كم تبلغ درجه حراره الشمس ؟", "15 مليون درجه مئوية", "15 ألف درجه مئوية", "10 مليون درجه مئوية", "مليون درجه مئوية", "1"},
{"113", "txt", "tarikh", "متى كانت أولى الرحلات إلى الفضاء؟", "عام 1951م", "عام 1961م", "عام 1971م", "عام 1981م", "2"},
{"114", "txt", "amma", "أكثر دولة تحدث فيها الزلازل ؟", "تايلاند", "تشيلي", "الموزمبيق", "الصين", "2"},
{"115", "txt", "amma", "أين توجد الآية  يا حسرة على العباد ", "نوح", "يس", "النمل", "هود", "2"},
{"116", "txt", "english", "When are you coming", "متى ستأتي ؟", "متى ستذهب ؟", "متى ستعمل ؟", "متى ستقرأ ؟", "1"},
{"117", "txt", "amma", "المانغا الأفضل مبيعا في اليابان ؟", "المحقق كونان", "دراغون بول", "ناروتو", "ون بيس", "4"},
{"118", "txt", "ilm", "إسم الجهاز الذي يستخدم في قياس الضغط الجوي ؟", "الترمومتر ", "البارومتر ", "المزطاب ", "الكيلو", "2"},
{"119", "txt", "taqafa", " أين يقع نهر الأمازون؟", "البرازيل", "المكسيك", "أمريكا الشمالية", "أمريكا الجنوبية", "4"},
{"120", "txt", "tarikh", "مكتشف قاعدة طفو الأجسام ؟", "أرخميدس", "نيوتن", "طاليس", "لا احد منهم", "1"},
{"121", "txt", "tarikh", "متى تأسست شركة آبل ؟", "2000 م", "1985 م", "1979 م", "1968 م", "3"},
{"122", "txt", "sport", "أول دولة عزفت النشيد الوطني ؟", "ألمانيا", "فرنسا", "البرازيل", "أمريكا", "4"},
{"123", "txt", "amma", " ما الدولة التي تعتبر شبه جزيرة داخل شبه جزيرة؟", "قطر", "سنغافورة", "ماليزيا", "بيرو", "1"},
{"124", "txt", "english", "هل انت متزوج ؟", "Are you hungry", "are you ready", "Are you married", "Are You With Me", "3"},
{"125", "txt", "amma", "يقال منارة زوراء ... ماذا تعني ؟", "مدورة", "ملونة", "مهدمة", "مائلة", "4"},
{"126", "txt", "taqafa", "من القائل: إن كان الكلام من فضةفالسكوت من ذهب", "لقمان", "عمر بن الخطاب", "علي بن ابي طالب", "بن تيمية", "1"},
{"127", "txt", "din", "من هو المؤسس الحقيقي للدولة العباسيةِ ؟", "محمد الأمين", "عبد الله المأمون", "أبو جعفر المنصور", "هارون الرشيد", "3"},
{"128", "txt", "ilm", "الظغط على زر F1 ", "نسخ ملف", "طلب ملف", "طلب مساعدة", "عرض خيارات", "3"},
{"129", "txt", "amma", "أهون البيوت ؟", "بيت الطين", "بيت النمل", "بيت النحل", "بيت العنكبوت", "4"},
{"130", "txt", "alghaz", "معنى الكلمة الأمازيغية ( أغروم ) ", "خبز", "زيت", "حليب", "لبن", "1"},
{"131", "txt", "din", "ما هو الشيئ الذي خلقه الله وعظمه ؟", "كيد الكافر", "كيد الشيطان", "كيد النساء", "كيد المنافق", "3"},
{"133", "txt", "amma", "في أي قارة جمهورية البيرو ؟", "أستراليا", "أمريكا الشمالية", "أمريكا الجنوبية", "آسيا", "3"},
{"134", "txt", "alghaz", "أنت تدخل حجرة مظلمة، ويوجد بداخل الحجرة موقد غاز ومصباح كيروسين، وشمعة. ولديك علبة الكبريت وعود ثقاب واحد داخل جيبك، ماذا سوف تشعل أولاً؟", "عود الكبريت", "موقد الغاز", "عود ثقاب", "مصباح كيروسين", "3"},
{"135", "txt", "taqafa", "من القائل(التعليم أفضل مؤونة للشيخوخة)", "افلاطون", "جالينوس", "ارسطو", "فيثاغورس", "3"},
{"136", "txt", "amma", "ما هي أكبر مدينة في أوربا ؟", "برلين", "مدريد", "باريس", "لندن", "4"},
{"137", "txt", "amma", "أين توجد أطول آية بالقرآن الكريم ؟", "المائدة", "البقرة", "آل العمران", "النساء", "2"},
{"138", "txt", "din", "من أول شخص كتب بسم الله الرحمن الرحيم؟", "جبريل عليه السلام", "النبي سليمان عليه السلام.", "آدم عليه السلام", "محمد عليه السلام", "2"},
{"139", "txt", "tarikh", "الميكادو  لقب يطلق على الامبراطور ؟", "النمساوي", "الياباني", "الاثيوبي", "الروماني", "2"},
{"140", "txt", "amma", " 4 + 4 ÷ 2 = ?", "6", "4", "2", "8", "1"},
{"141", "txt", "amma", "كم يعيش النسر ؟", "10 سنوات", "30 سنة", "100 سنة", "120 سمة", "3"},
{"142", "txt", "taqafa", "كم شهر في السنة به 28 يومًا؟", "شهر واحد", "شهرين", "ثلاث أشهر", "جميع الأشهر", "4"},
{"144", "txt", "tarikh", "من اخترع الصفر ؟", "فيثاغورس", "الخوارزمي", "إقليدس", "عمرالخيّام", "2"},
{"145", "txt", "taqafa", " ما هي عملة اليابان؟", "الجنيه", "الدولار", "اليوان", "الين", "4"},
{"146", "txt", "amma", "أين يوجد جبل ماكالو ؟", "ماليزيا", "الهند", "اليابان", "الصين", "4"},
{"147", "txt", "ilm", "ماهو علم الجيولوجيا ؟", "علم الأرصاد الجوية", "علم الخلايا", "علم الأرض", "علم الأجناس", "3"},
{"148", "txt", "sport", "أين وضعت قوانين كرة القدم لأول مرة ؟", "بريطانيا", "إنجلترا", "الارجنتين", "المانيا", "2"},
{"149", "txt", "alghaz", " أخت خالك و ليست خالتك من تكون ؟", "عمتك", "أختك", "أمك", "خالتك", "3"},
{"150", "txt", "ilm", "كم من مستوى للاحتياجات في هرم ماسلو ؟", "4", "5", "6", "7", "2"},
{"151", "txt", "ilm", "من الذي أسس علم الجبر؟", "اقليدس", "جابر ابن حيان", "الخوارزمي", "فيثاغورس", "3"},
{"152", "txt", "din", "مااسم الديانه الاكثر شيوعا في الهند ؟", "الهندوسية", "البودية", "اليهودية", "المسيحية", "1"},
{"153", "txt", "amma", "أين توجد أقصر آية بالقرآن الكريم ؟", "البقرة", "الكوثر", "الرحمان", "العصر", "3"},
{"154", "txt", "sport", "ما هي أم الألعاب الرياضية ؟", "فوروسية", "كرة القدم", "الشطرنج", "ألعاب القوى", "4"},
{"155", "txt", "taqafa", " كم قلب يمتلكه الأخطبوط؟", "قلب واحد", "قلبين", "3 قلوب", "4 قلوب", "3"},
{"156", "txt", "sport", " أين اقيمت بطولة كأس العالم 2002 ؟", "اورغواي", "كوريا واليابان", "البرازيل", "غانا", "2"},
{"157", "txt", "amma", "متى تأسست شركة Sony ؟", "1946 م", "1956 م", "1985 م", "1991 م", "1"},
{"158", "txt", "ilm", "ما هو علم السيتولوجيا؟", "علم الارض", "علم الخلايا", "علم الأجنة", "علم الاجتماع", "2"},
{"160", "txt", "taqafa", " ما هو أقوى حيوان في الذاكرة؟", "الجمل", "النعامة", "القرد", "الدلفين", "1"},
{"161", "txt", "din", " كم يوم خلق الله فيه الأرض؟", "6 أيام", "7 أيام", "يوم واحد", "50 ألف يوم", "1"},
{"162", "txt", "amma", "ما هو عدد السجدات في القرآن الكريم ؟", "12 سجدة", "14 سجدة", "15 سجدة", "21 سجدة", "2"},
{"164", "txt", "sport", "مدرب المنتخب المصري سنة 2015 ؟", "هيكتور كوبر", "وينفريد شايفر", "مورتن أولسن", "هنري ميشيل", "1"},
{"165", "txt", "ahaji", " ما الشيء الذي لا يتحدث وإذا جاع يكذب وإذا شبع صدق؟", "المذياع", "الساعة", "التلفاز", "الهاتف", "2"},
{"166", "txt", "sport", "اللعبة الأكثر جدلا بالعالم  ؟", "ببجي", "الحوت الأزرق", "فري فاير", "لعبة بوكمون", "4"},
{"167", "txt", "amma", "مؤسس آبل ؟", "ستيف جوبز", "رونالد واين", "ستيف وزنياك", "تيم كوك", "1"},
{"168", "txt", "amma", "مفتاح هاتف دولة السعودية ؟", "+931", "+966", "+976", "+944", "2"},
{"169", "txt", "english", "هل تشاهد الافلام الاجنبيه ؟", "Do you always have nightmares ", "Do you watch American film", "Do you like to get a lot of friends", "Did you travel abroad ? where to", "2"},
{"170", "txt", "ilm", "كم يبلغ عدد الأحبال الصوتية لدى الإنسان؟ ", "2 أحبال صوتية", "3 أحبال صوتية", "4 أحبال صوتية", "5 أحبال صوتية", "3"},
{"171", "txt", "alghaz", "صغير الضب ؟", "السقنقور", "حسل", "حيتان", "سنور", "2"},
{"172", "txt", "amma", "القيصر لقب يطلق على الامبراطور ؟", "الاثيوبي", "الياباني", "الروماني", "التركي", "3"},
{"173", "txt", "ilm", "ما هو أقرب الكواكب إلى الشمس؟", "عطارد", "الزهرة", "المريخ", "المشتري", "1"},
{"174", "txt", "awasim", "عاصمة اليونان ؟", "أنقرة", "أكرا", "أثينا", "أسمرة", "3"},
{"175", "txt", "amma", " في أي قارة تقع دولة فلسطين؟", "قارة افريقيا", "قارة أنتاركتيكا", "قارة آسيا", "قارة أوروبا", "3"},
{"176", "txt", "amma", "أي دولة لها مفتاح  الهاتف +213", "مصر", "الجزائر", "تونس", "موريتانيا", "2"},
{"177", "txt", "amma", "ما هو الزنجار ؟", "صدأ الألمنيون", "صدأ الحديد", "صدأ الزنك", "صدأ النحاس", "4"},
{"178", "txt", "taqafa", "ما هي أقدم جامعات العالم؟", "جامعة أوكسفورد", "جامعة القرويين بالمغرب", "جامعة بروكسل الحرة", "جامعة صوفيا", "2"},
{"179", "txt", "amma", "ما هو موقع  PayPal", "ليس بموقع", "موقع تجاري", "موقع تواصل اجتماعي", "بنك الكتروني", "4"},
{"180", "txt", "ilm", "أول إنسان لقب برائد فضاء في العالم ؟", "نيل آرمسترونغ", "يورى غاغارين", "فالنتينا تريشكوفا ", "بز ألدرن", "2"},
{"181", "txt", "taqafa", "أين توجد أطول سكة حديدية في العالم ؟", "كندا", "أمريكا", "ألمانيا", "اليابان", "1"},
{"182", "txt", "alghaz", "الأقوى ؟", "الزنك", "النحاس", "الحديد", "أحجار المغناطيس", "3"},
{"183", "txt", "din", "آخر صحابي مات رأى محمد صلى الله عليه وسلم ؟", "أنس بن مالك", "الحسن البصري", "أبو الطفيل الليثى", "عبد الله بن عمر", "3"},
{"184", "txt", "sport", "أول منتخب عربي صعد إلى كأس العالم ؟", "جنوب افريقيا", "تونس", "مصر", "الجزائر", "3"},
{"185", "txt", "amma", " ما أكبر خليج بالعالم؟", "خليج بونيفاسيو الفرنسي", "الخليج المكسيكي", "خليج كونانغ يوان بتايلند", "خليج كوركوفادو", "2"},
{"186", "txt", "taqafa", "كم جناح لدى النحلة؟", "جناح واحد", "جناحين في كل جناح", "زوجين من الأجنحة", "ليس لها أجنحة", "3"},
{"188", "txt", "taqafa", " ما أغلى معدن بالعالم في السعر؟", "الذهب", "الراديوم", "الزمرد", "الماس", "2"},
{"189", "txt", "taqafa", "عملة جامايكا ؟", "الدولار", "الأورو", "الجنيه", "الدرهم", "1"},
{"190", "txt", "din", " من النبي الذي قبض الله روحه في السماء؟", "عيسى عليه السلام", "آدم عليه السلام", "موسى عليه السلام", "إدريس عليه السلام", "4"},
{"191", "txt", "taqafa", "ما هو أسرع حيوان بالعالم؟", "الأسد", "الفهد", "النمر", "الكلب", "2"},
{"192", "txt", "ilm", "في ماذا تستخدم كلمة if في البرمجة ؟", "هي كلمة شرط", "هي كلمة تكرار", "هي مصفوفة", "هي دالة", "1"},
{"193", "txt", "taqafa", "ما هو إسم أنثى الحمار؟", "جحش", "الحمار", "حِمَارَة", "الأتان", "4"},
{"194", "txt", "din", "السورة التي قرأت على النجاشي ففاضت دموعه ؟", "سورة آل العمران", "سورة ابراهيم", "سورة طه", "سورة مريم", "4"},
{"195", "txt", "sport", "من ابتكر لعبة البلياردو ستة 1429م ؟", "الرومان", "الاغريقيون", "الفرنسيون", "الفارسيون", "3"},
{"197", "txt", "amma", "صاحب قصدية بانت سعاد ", "", "", "", "", "2"},
{"198", "txt", "amma", "المعدن الأغلى في العالم ؟", "الماس", "الراديوم", "الذهب", "الزبرجد", "2"},
{"199", "txt", "alghaz", "قام رجل بشراء حصان بسعر 10 دولار، وباعه بسعر 20 دولار، ثم قام بشراء نفس الحصان بسعر 30 دولار وباعه بسعر 40 دولار. ما هو كامل الدخل الذي حصل عليه في الأخير ؟", "0 دولار", "10 دولار", "20 دولار", "30 دولار", "3"},
{"200", "txt", "din", "من الذي بنى مدينة الكوفي ؟", "خالد بن الوليد", "ابو عبيدة بن الجراح", "المثتى", "سعد بن ابي وقاص", "4"},
{"201", "txt", "sport", "على ماذا تدل x ؟", "الخارج", "الناتج", "الغائب", "المجهول", "4"},
{"203", "txt", "amma", "الحيوان الذي لا يقدر على السباحة ؟", "الضبع", "البغل", "البقرة", "الجمل", "4"},
{"204", "txt", "alghaz", "هناك إثنان يمشيان تجاه بعضهمها البعض، من منهما سوف يبدأ بتحية الآخر؟", "الشخص الأكثر أدباً", "الشخص الأكبر سنا", "الشخص الذي على اليمين", "لا داعي لإلقاء التحية", "1"},
{"205", "txt", "", "أسرع النباتات نموا ؟", "قصب السكر", "الزيتون", "الكلبتوس", "الخيزران", "4"},
{"206", "txt", "sport", "أسرع دراجة نارية سنة 2016 ؟", "دراجة توماهاوك", "سيزيكي هايبوسا", "هوندا سي بي إر", "ياماها أر ون", "1"},
{"207", "txt", "amma", "وصيف وبغا الصغير  هما قائدان ؟", "عربيان", "فارسيان", "تركيان", "هنديان", "3"},
{"208", "txt", "amma", "أين يوجد نهر ينسي ؟", "سيبيريا", "بنغلاديش", "تركيا", "كينيا", "1"},
{"209", "txt", "awasim", "العاصمة العلمية بالمغرب ؟", "الرباط", "الدار البيضاء", "مراكش", "فاس", "4"},
{"210", "txt", "sport", "أسرع سيارة عام 2010/2011", "لومبر جيني", "فيراري", "بوجاتي", "بورش", "3"},
{"212", "txt", "awasim", "ما هي عاصمة الدانمارك", "امستردام", "كوبنهاغن", "فريكشهاون", "آلبورغ", "2"},
{"213", "txt", "english", "? how", "لمن ؟", "كيف؟", "لماذا؟", "لم لا ؟", "2"},
{"215", "txt", "tarikh", "أول دولة خليجية ظهر فيها البترول ؟", "البحرين", "الامارات", "السعودية", "الكويت", "1"},
{"216", "txt", "amma", "ما هي السورة التي لا توجد بها بسملة ؟", "التوبة", "النمل", "الصافات", "النحل", "1"},
{"217", "txt", "amma", "ما أول دولة استخدمت طابع البريد؟", "فرنسا", "بريطانيا", "سويسرا", "البرازيل", "2"},
{"218", "txt", "taqafa", "من الذي رسم لوحة الموناليزا؟", "الرسام بيكاسو", "الرسام  فرانثيسكو غويا", "الرسام سلفادور دالي", "الرسام ليوناردو دافنشي", "4"},
{"219", "txt", "taqafa", "ما هو أعلى جبل في العالم؟", "تويقال", "ايلفيرست", "مدغشقر", "الالب", "2"},
{"220", "txt", "english", "كم عدد أحرف اللغة الإنجليزية؟", "25 حرفاً", "26 حرفاً", "27 حرفاً", "28 حرفاً", "2"},
{"221", "txt", "english", "After she … her study, she got married", "finish", " has finished", "is finishing", "had finished", "4"},
{"222", "txt", "amma", " أين تم صناعة كسوة الكعبة لأول مرة؟", "دمشق", "مكة", "فلسطين", "مصر", "4"},
{"224", "txt", "amma", "كم عدد العظام الموجودة في جسم الإنسان ؟", "201", "206", "205", "204", "2"},
{"225", "txt", "awasim", "عاصمة كرواتيا ؟", "زغرب", "سايبان", "سانتياغو", "سكوبيا", "1"},
{"226", "txt", "awasim", "أحد هذه المدن ليست في تركيا ؟", "أنقرة", "إسطنبول", "لاريسا", "كاهاتا", "3"},
{"227", "txt", "english", "Jenny ___________ tired.", " Be", "Is", "Has", "Have", "2"},
{"228", "txt", "amma", "القلب يدق 60 دقة في الدقيقة كم يدق في الساعة ؟", "900", "1800", "3600", "7600", "3"},
{"229", "txt", "din", " أول شئ يسأل عنه المرء يوم القيامه ؟", "الصوم", "بره لوالديه", "الاخلاق", "الصلاة", "4"},
{"230", "txt", "amma", "ما هو أقوى أنواع الحجارة؟", "حجر اللازورد", "الألماس", "الياقوت الأحمر", "اللؤلؤ", "2"},
{"231", "txt", "taqafa", "ما هي بلد المليون شهيد؟", "ليبيا", "العراق", "أفغنستان", "الجزائر", "4"},
{"232", "txt", "amma", "مخترع الفيس بوك ؟", "جون", "لويس", "مارك", "البيرت", "3"},
{"233", "txt", "amma", "أي دولة لها مفتاح الهاتف +964", "تركيا", "البرازيل", "العراق", "السعودية", "3"},
{"234", "txt", "amma", "أين توجد أقدم جامعة بالعالم ؟", "المغرب", "تونس", "فرنسا", "إيطاليا", "1"},
{"236", "txt", "amma", "الحيوان الأشد سما ؟", "العنكبوت", "الافعى", "الاخطبوط", "قنديل البحر", "4"},
{"237", "txt", "taqafa", "مقياس سرعة السفن ؟ ", "البوصة", "الكيلومتر", "الميل", "العقدة", "4"},
{"238", "txt", "english", "متى تستيقظ ؟", "What do you say", "What time do you get up ", "Do you speak English", "How do you go to work", "2"},
{"240", "txt", "taqafa", "لسانك لا تذكر به عورة امرئ *** فكلك عورات وللناس ألسن", "الشافعي", "ابن حنبل", "الامام مالك", "ابن القيم", "1"},
{"241", "txt", "english", "Are you hungry ؟", "هل انت شبعان ؟", "هل انت مسافر؟", "هل انت عطشان ؟", "هل انت جائع ؟", "4"},
{"242", "txt", "amma", "المعنى الحقيقي للجملة المغربية باللغة العربية  (ادخل سوق راسك)", "إشأن شأنك", "انت وشأنك", "الشأن شأنك", "اعتني بشأنك", "1"},
{"243", "txt", "din", "في أي عام ترجم القرآن إلى اللغة الفرنسية ؟", "1351 م", "1547م ", "1347م ", " 1447 م ", "3"},
{"244", "txt", "taqafa", " بمَ تُقاس سرعة السفن؟", "الميل", "البوصة", "الكيلومتر", "العقدة", "4"},
{"245", "txt", "ilm", "ما هو (حصان طروادة)", "فيروس", "برنامج", "لعبة", "نظام", "1"},
{"246", "txt", "taqafa", " ما هو أول بيت تم بناءه في الأرض؟", "بيت المقدس", "البيت المعمور", "بيت الحكمة", "الكعبة الشريفة", "4"},
{"247", "txt", "sport", "كم يزن كأس العالم لكرة القدم  الجديد ؟", "5 كيلو من الذهب", "7 كيلو من الذهب", "6 كيلو من الذهب", "4 كيلو من الذهب", "1"},
{"248", "txt", "tarikh", "أول من وضع الحروف الهجائية ؟", "الفينقيون", "العرب", "الرومان", "العثمانيون", "1"},
{"249", "txt", "amma", " توجد أطول شجرة في العالم ؟", "كاليفورنيا", "نييوروك", "لويس أنجلوس", "هون كونغ", "1"},
{"250", "txt", "taqafa", " بمَ يُلقب كوكب بلوتو؟", "الكوكب القزم", "الكوكب البعيد", "الكوكب المجهول", "الكوكب النادر", "1"},
{"251", "txt", "awasim", "عاصمة المملكة المتحدة ؟", "واشنطن", "موسكو", "موناكو", "لندن", "4"},
{"252", "txt", "ilm", " ترددات الراديو ؟", "ميجاهرتز", "ميجابيت", "وات", "اومبير ميتر", "1"},
{"253", "txt", "taqafa", " ما أول دولة شرعت بالألعاب الأولمبية؟", "اليونان", " ألبانيا", "كولومبيا", " السلفادور", "1"},
{"254", "txt", "amma", "من هو أول رئيس للعراق ؟", "صدام حسين", "عبدالكريم قاسم", "الحجاج", "شكري القوتلي", "2"},
{"255", "txt", "din", "إنما بعثت لأتمم ....... الأخلاق ؟", "محاسن", "مكارم", "معالم", "مجامل", "2"},
{"256", "txt", "amma", "ماهي اللغة الرسمية للأرجنتين ؟", "الفرنسية", "الإنجليزية", "البرتغالية", "الإسبانية", "4"},
{"257", "txt", "din", "ما هي حرفة داوود عليه السلام ؟", "نجار ", "راعي الغنم", "حداد", "خياط", "3"},
{"258", "txt", "taqafa", "من القائل:صعدت باء الغباء ، لتخدع الناس بالغناء", "النابلسي", "أحمد الشقيري", "علي الكيالي", "ابراهيم الفقي", "2"},
{"259", "txt", "din", "اول رسول من الله ؟", "عيسى عليه السلام", "موسى عليه السلام", "إبراهيم عليه السلام", "نوح عليه السلام", "4"},
{"260", "txt", "amma", "اللغة الرسمية للبرازيل ؟", "الإسبانية", "البرتغالية", "الإنجليزية", "الفرنسية", "2"},
{"261", "txt", "ilm", "مؤسس علم الجبر ؟", "الفرابي", "العالم المسلم جابر بن حيان", "بن سينا", "العالم المسلم الخوارزمي", "4"},
{"262", "txt", "ilm", "أصعب لغة برمجة ؟", "جافا", "الفيجو البيسك", "سي", "الإسمبلي", "4"},
{"263", "txt", "sport", "أين أقيمت أول بطولة لكأس العالم بكرة القدم؟", "إيطاليا", "الأوروغواي", "انجلترا", "البرازيل", "2"},
{"264", "txt", "tarikh", "مؤسس المملكة العربية السعودية ؟", "عبد العزيز بن سعود", "سعود بن عبد العزيز", "فيصل بن عبد العزيز ", "خالد بن عبد العزيز", "1"},
{"265", "txt", "tarikh", "متى تأسس واتساب ؟", "2009", "2011", "2013", "1015", "1"},
{"266", "txt", "taqafa", " ما الحيوان الذي يُعرف بأبو الأخطل؟", "الفرس", "الحمار", "البغل", "الأسد", "3"},
{"267", "txt", "taqafa", "ما هو الكوكب الأحمر؟", "كوكب زحل", "كوكب عطارد", "كوكب المريخ", "كوكب بلوتو", "3"},
{"268", "txt", "amma", "ما هو أطول أنهار العالم؟", "نهر الامازون", "نهر دجلة", "نهر المسيسيبي", "نهر النيل", "4"},
{"269", "txt", "taqafa", " بأي دولة توجد بحيرة قارون؟", "بغداد", "ليبيا", "مصر", "تونس", "3"},
{"270", "txt", "awasim", "القيروان يقع في ؟", "تونس", "الجزائر", "المغرب", "ليبيا", "1"},
{"271", "txt", "din", "ما هو الشيء الذي خلقه الله واستنكره ؟", "صوت الحمير", "صوت البغال", "صوت الفرس", "صوت الكافر", "1"},
{"272", "txt", "taqafa", " أين يوجد تمثال أبو الهول؟", "مصر", "فلسطين", "العراق", "ليبيا", "1"},
{"273", "txt", "taqafa", " ما المسافة التي كانت زرقاء اليمامة تراها ؟", "مسافة مسيرة يوم", "مسافة مسيرة 3 أيام", "مسافة مسيرة 10 أيام", "مسافة مسيرة شهر", "2"},
{"274", "txt", "ilm", "من هو العالم الذي إخترع التلسكوب ؟", "ماركوني", "ألبرت أينشتاين", "ابن سينا", "جاليليو ", "4"},
{"275", "txt", "taqafa", " ما هو أكبر تمثال نحاسي بالعالم؟", "تمثال زيوس", "تمثال هرقل", "تمثال رودس", "تمثال الحرية بالولايات المتحدة", "4"},
{"277", "txt", "din", "ما هو يوم الحج الأكبر؟", "عيد الأضحى", "يوم النحر", "الحج", "يوم عرفة", "2"},
{"278", "txt", "tarikh", "أقدم لغة مكتوبة في العالم ؟", "السريانية", "الصينية", "العربية", "الفارسية", "2"},
{"279", "txt", "amma", "كم عدد الكتب السماوية ؟", "3 كتب", "6 كتب", "5 كتب", "4 كتب", "4"},
{"280", "txt", "amma", "ماهي أكبر دوله عربيه مساحه ؟", "الجزائر", "السودان", "السعودية", "موريتانيا", "2"},
{"281", "txt", "din", " ما هي أول العملات الإسلامية؟", "الدرهم", "الريال", "الذهب", "الدينار", "4"},
{"282", "txt", "sport", "أين يوجد موطن لعبة الهوكي ؟", "اليابان", "الهند", "الفلبين", "تايلاند", "2"},
{"283", "txt", "tarikh", "مخترع الديناميت ؟", "اسحاق نيوتن", "وليام كري", "فيلوفرانسورت", "نوبل", "4"},
{"284", "txt", "taqafa", "من القائل:من سالم الناس سلم *** ومن شاتم الناس شتم", "ابرهيم بن ادهم", "المتنبي", "الشافعي", "ابا العتاهية", "4"},
{"285", "txt", "taqafa", "ما هو أكبر المحيطات بالعالم؟", "المحيط الهندي", "المحيط المتجمد الشمالي", "المحيط الهادي", "المحيط المتجمد الجنوبي", "3"},
{"286", "txt", "taqafa", " ما الدولة التي تتكون من عدة جزر على شكل الهلال؟", "الهلال الخصيب", "جزر المالديف", "جزر القمر", "كيلو جزر", "3"},
{"287", "txt", "amma", "كم عدد سور القرآن ؟", "60 سورة", "114 سورة", "99 سورة", "63 سورة", "2"},
{"289", "txt", "ilm", "ما إسم وحده قياس شدة الصوت ؟", "الميجابيت", "الديسيبل", "ريشتر", "ميليمتر", "2"},
{"290", "txt", "taqafa", "أول انسان قتل على الأرض ؟", "هابيل", "قابيل", "شيث", "احد الانبياء", "1"},
{"291", "txt", "taqafa", " بماذا يسمى صغير الحمار؟", "الحصان ", "حمير", "الجحش", "أَتَان", "3"},
{"292", "txt", "tarikh", "أرض بابل حاليا ؟", "فلسطين", "العراق", "السعودية", "مصر", "1"},
{"293", "txt", "alghaz", "شخص قال: لو كان أمس هو غدا...لكان اليوم هو يوم السبت . في أي يوم كان هذا الشخص؟", "السبت", "الأحد", "الاثنين ", "الثلاثاء", "3"},
{"294", "txt", "taqafa", "أول قصيدة إنشادية للعفاسي ؟", "خلي الدكار الاربع", "أيا من يدعي الفهم", "طلبع البدر علينا", "ليس الغريب", "2"},
{"295", "txt", "english", "معنى الكلمة الانجليزية how are you", "كيف حالك", "هل انت بخير", "كيف انت", "حالك جيد", "1"},
{"296", "txt", "awasim", " أي المدن كانت عاصمة الدولة العباسية؟", "بغداد", "الرافقة", "القصور", "سامراء", "1"},
{"297", "txt", "awasim", "ما هي عاصمة الهند ؟", "مومباي", "جايبور", "نيودلهي", "دلهي", "3"},
{"298", "txt", "ilm", "5 + 2 x 3 = ?", "11", "21", "18", "12", "1"},
{"299", "txt", "taqafa", " أي الحيوانات يمكن أن يُصاب بالحصبة؟", "القرد", "الفيل", "الخنزير", "الأسد", "1"},
{"300", "txt", "amma", "قمر اصطناعي تم التقاط به صور خريطة جوجل ؟", "آلسات", "فالكون", "هابل", "كوروت", "3"},
{"301", "txt", "taqafa", "من الذي إكتشف الدورة الدموية الصغرى؟", "ابن سينا", "ابن البيطار", "ابن النفيس", "ابن رشد", "3"},
{"302", "txt", "amma", "متى تأسس فيس بوك ؟", "2000 م", "2002 م", "2004 م", "2006 م", "3"},
{"303", "txt", "amma", "أطول سورة في القرآن الكريم ؟", "الأعلى", "الصافات", "البقرة", "المائدة", "3"},
{"304", "txt", "taqafa", "ما هي أول بلد عرفت التلفيزيون؟", "ألمانيا", "الولايات المتحدة", "اطاليا", "ألمانيا", "2"},
{"306", "txt", "english", "How much is your height ؟", "كم طولك ؟", "كم تزن ؟", "كم وزنك ؟", "كم عمرك ؟", "1"},
{"307", "txt", "taqafa", " أي الحيوانات أطلق عليها العرب اسم أم حائل؟", "البغل", "الشاة", "الناقة", "الحمار", "3"},
{"309", "txt", "amma", "أخطر هاكرز في الحاسوب ؟", "حمزة بن دلاج", "كيفن ميتنيك", "كيفن بولسن", "مستر روبوت", "2"},
{"310", "txt", "english", "عندي سؤال ؟", "?  you have a question", "How do you do question? ", "?  I have a question", "?  i am a question", "3"},
{"311", "txt", "tarikh", " ما أول جامع تم بناءه في مصر؟", "جامع عمرو بن العاص.", "مسجد السيدة زينب", "مسجد سادات قريش", "الجامع الأزهر", "1"},
{"312", "txt", "amma", "ماهي كارثة القرن العشرين ؟", "الحرب العالمية الثانية", "زلزال أكادير بالمغرب", "تسونامي تايلاند", "التكنلوجيا", "2"},
{"313", "txt", "awasim", "مدينة توجد بالعراق ؟", "كركوك", "طبريا", "بيسان", "العمرية", "1"},
{"314", "txt", "ilm", "ماهو أقرب كوكب إلى الارض ؟", "عطارد", "نبتون", "الزهرة", "الشمس", "3"},
{"315", "txt", "taqafa", "ما هي أصغر الدول العربية في المساحة؟", "مالطا", "البحرين", "تونس", "الفاتيكان", "2"},
{"316", "txt", "amma", "أول مولود في الإسلام ؟", "عبدالله بن الزبير", "عبد الله بن رباح", "عبد الله بن عمر", "بلال بن رباح", "1"},
{"318", "txt", "amma", "كم تحتوي ملعقة زيت الزيتون من سعة حرارية ؟", "120 سعة حرارية", "140 سعة حرارية", "180 سعة حرارية", "220 سعة حرارية", "1"},
{"319", "txt", "amma", "حيوان لا يشرب الماء ؟", "الخنزير", "الجمل", "الزرافة", "الكنغر", "4"},
{"320", "txt", "amma", " ما اسم المدينة التي تُعرف باسم مدينة الظلام؟", "مدينة ريو دي جانيرو", "مدينة لندن", "مدينة مورمانسك", "مدينة باريس", "2"},
{"321", "txt", "tarikh", " في أي عام كانت مذبحة صبرا وشاتيلا؟", "عام 1882م", "عام 1782م", "عام 1982م", "عام 1682م", "3"},
{"322", "txt", "amma", " ما هي لغة دولة النمسا؟", "النمساوية", "الانجليزية", "الفرنسية", "الألمانية", "4"},
{"323", "txt", "amma", "أكبر مكتبة بالعالم ؟", "مكتبة بيروت", "مكتبة الفاتيكان", "مكتبة الكونغرس", "مكتبة الإسكندرية", "3"},
{"324", "txt", "alghaz", "بماذا يتم تشفير كلمة مرور مواقع الانترنت ؟", "HEX", "MD5", "Byte", "Java", "2"},
{"325", "txt", "tarikh", "مخترع المصباح ؟", " اديسون", "نيوتن", "نابليون", "نوبل", "1"},
{"327", "txt", "taqafa", " ما إسم المتنبي الحقيقي؟", "أبو الطيب المتنبي", "أبو تمام", "سيف الدولة الحمداني", "أحمد بن الحسين", "4"},
{"328", "txt", "taqafa", " ما هي أطول القنوات المائية الصناعية بالعالم؟", "قناة دورتموند ارنست", "قناة كيل", "قناة شمال بجر البلطيق", "قناة السويس بمصر", "4"},
{"329", "txt", "amma", "أكبر مدينة إفريقية ؟", "الدار البيضاء", "القاهرة", "الجزائر العاصة", "طرابلس", "2"},
{"330", "txt", "amma", "أول داعية إسلامي ؟", "عبيدة بن الجراح", "زيد بن حارثة", "مصعب بن عمير", "خالد بن الوليد", "3"},
{"331", "txt", "ilm", "أحد الألون ليست رئيسية ؟", "أخضر", "أزرق", "أصفر", "أحمر", "1"},
{"332", "txt", "amma", "كم قلب للأخطبوط ؟", "3", "4", "5", "1", "1"},
{"333", "txt", "tarikh", "أول كمبيوتر محمول ؟", "IBM", "DELL", "MAC", "HP", "1"},
{"334", "txt", "taqafa", " ما هي لغة دولة البرازيل؟", "البرازيلية", "البرتغالية", "الاسبانية", "الانجليزية", "2"},
{"335", "txt", "amma", "فيتامين يساعد في تقوية النظر ؟", "C", "D", "A", "B", "3"},
{"336", "txt", "din", "ما هو الشرك الأصغر؟", "النميمة", "الغيبة", "الزنا", "الرياء", "4"},
{"337", "txt", "amma", "من القائل العقل السليم في الجسم السليم ؟", "أرسطو", "أفلاطون", "عمر بن الخطاب", "علي بن ابي طالب", "2"},
{"338", "txt", "taqafa", " ما اسم أنثى الغزال؟", "رشأ", "غزل", "عفراء", "ظبية", "4"},
{"339", "txt", "ilm", "معنى النطاق ( com )", "تعليمي", "تجاري", "معلومات", "شبكات", "2"},
{"340", "txt", "alghaz", " إذا كنت في سباق. و تجاوزت المتسابق الثاني. فماذا سيكون ترتيبك ؟", "الأول", "الثاني", "الثالث", "الرابع", "2"},
{"341", "txt", "amma", "ما هي لغة النمسا ؟", "اللغة الإنجليزية", "اللغة الألمانية", "اللغة الفرنسية", "اللغة النمساوية", "2"},
{"342", "txt", "awasim", "ما هي عاصمة الصومال ؟", "أبوجا", "الخرطوم", "مقديشو", "سانتياغو", "3"},
{"343", "txt", "din", " ما اسم الجبل الذي كلم الله عليه نبيه موسى؟", "جبل أحد", "جبل النور", "جبل الطور", "جبل عرفة", "3"},
{"344", "txt", "amma", "ماهي أصغر دوله عربيه مساحه ؟", "تونس", "البحرين", "الكويت", "توركيا", "2"},
{"345", "txt", "taqafa", " في أي قارة تقع دولة فيتنام؟", "قارة أوروبا", "قارة  أمريكا", "قارة  إفريقيا", "قارة آسيا", "4"},
{"346", "txt", "ilm", " كم تبلغ درجة حرارة الشمس؟", "6000 درجة مئوية تقريبًا", "مليون درجة مئوية تقريبًا", "15 مليون درجة مئوية تقريبًا", "صفر درجة مئوية ", "3"},
{"347", "txt", "amma", "مؤسس شركة ميكروسوفت ؟", "جون تومسون", "بيل غيتس", "بول ألين", "ساتيا ناديلا", "2"},
{"348", "txt", "din", "كم عدد سور القران ؟", "66", "114", "33", "99", "2"},
{"349", "txt", "taqafa", " ما هي أعلى نقطة على سطح الأرض؟", "جبل تبقال", "جبل كاترين", "قمة إفرست", "قمة تاهات", "3"},
{"350", "txt", "awasim", "عاصمة ماليزيا ؟", "سيلانجور", "كوالا لمبور", "بينانج", "كلنتان", "2"},
{"351", "txt", "amma", "من مؤسس علم الجبر ؟", "ابن حيان", "طاليس", "الخوارزمي", "بن سينا", "3"},
{"352", "txt", "amma", "عدد السعرات الحرارية في كأس الماء ؟", "صفر", "واحد", "اثنان", "ثلاثة", "1"},
{"353", "txt", "din", "قال تعالى (وَالْعَادِيَاتِ ضَبْحًا) المقصود بالعاديات ؟", "الخيول", "الطيور", "الابل", "الغنم", "1"},
{"354", "txt", "amma", "أين يوجد جامع الزيتون ؟", "المغرب", "الجزائر", "تونس", "مصر", "3"},
{"355", "txt", "amma", "أسرع طائرة ركاب بالعالم ؟", "فالكون", "كونكورد", "بلاكبيرد", "بووم", "2"},
{"356", "txt", "sport", "أول دولة منظمة لبطولة كأس العالم للشباب ؟", "تركيا", "ايطاليا", "تونس", "فرنسا", "3"},
{"357", "txt", "english", "كم عمرك ؟", "What are you doing ", "How are you", "How old are you", "What is your name", "3"},
{"358", "txt", "amma", "العالم الذي قام باختراع أول ماكينة حلاقة ؟", "كينج جيليت", "ألفرد نوبل", "لويس بايل", "صامويل", "1"},
{"360", "txt", "tarikh", "متى صدرت لعبة GTA 5 ؟", "2010", "2015", "2013", "2011", "3"},
{"361", "txt", "ilm", "للنسخ عليك الضغط على ..... ؟", "Ctrl+a", "Ctrl+v", "Ctrl+c", "Ctrl+z", "3"},
{"362", "txt", "taqafa", " كم بوصة توجد في الياردة الواحدة؟", "36 بوصة", "100 بوصة", "50 بوصة", "21 بوصة", "1"},
{"363", "txt", "din", "كم يوم بين عيد الفطر وعيد الأضحى ؟", "75 يوم", "60 يوم", "70 يوم", "80 يوم", "3"},
{"364", "txt", "amma", "أقصر سورة في القرآن الكريم ؟", "الكوثر", "العصر", "الفلق", "الفاتحة", "1"},
{"365", "txt", "amma", "السورة التي تقع بين سورة الاسراء وسورة مريم ؟", "سورة طه", "سورة الكهف", "سورة الرعد", "سورة النحل", "2"},
{"366", "txt", "awasim", "عاصمه أستراليا ؟", "فكتوريا", "سيدني", "بالارات", "كانبيرا", "4"},
{"367", "txt", "taqafa", " كم تبلغ عدد أرجل العنكبوت؟", "2 أرجل", "4 أرجل", "8 أرجل", "12 أرجل", "3"},
{"368", "txt", "amma", "ماهي مدينة المائة باب ؟", "القاهرة", "الجزائر", "الرباط", "طرابلس", "1"},
{"369", "txt", "english", "? why", "كيف؟", "لمن ؟", "لماذا؟ ", "ماذا؟ ", "3"},
{"370", "txt", "amma", "ما هي بلد المليون شهيد ؟", "مصر", "الجزائر", "ليبيا", "تركيا", "2"},
{"372", "txt", "ilm", "خضر يحتوي على شحنات كهربائية ؟", "بصل", "بادنجان", "طماطم", "بطاطس", "4"},
{"373", "txt", "amma", "معدن في حالة سائلة ؟", "الزئبق", "البترول", "الكبريت", "حمم بركانية", "1"},
{"374", "txt", "alghaz", "يموت إذا فتحت فمه أكثر من دقيقة ؟", "السمك", "الضفدع", "التمساح", "الضب", "2"},
{"375", "txt", "taqafa", "كم عدد ألون قوس قزح؟", "5 ألوان", "6 ألوان", "7 ألوان", "8 ألوان", "3"},
{"376", "txt", "taqafa", "من القائل:وإذا كانت التفوس كبارا *** تعبت في مرادها الأجسام", "نزار قباني", "جبران خليل جبران", "المتنبي", "ابن عربي", "3"},
{"377", "txt", "din", "صاحب قصدية بانت سعاد ؟", "كعب بن زهير", "حسان بن ثابت", "ابو قيس الانصاري", "ابن قيس الرقيات", "1"}
}


End Class
