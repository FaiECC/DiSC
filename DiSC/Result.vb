Public Class Result

    Public most() As Integer = Quiz13.most  'Array for keeping most value
    Public least() As Integer = Quiz13.least 'Array for keeping least value

    Dim user As String = Login.UserTextBox.Text

    Dim D As Integer = (most(0) - least(0))
    Dim I As Integer = (most(1) - least(1))
    Dim S As Integer = (most(2) - least(2))
    Dim C As Integer = (most(3) - least(3))

    'Result setting
    Dim reDC As String = " People With DC style prioritize Challenge, so they want to explore all options And make sure that 
the best possible methods are used. As a result, they may be very questioning And skeptical of 
other people's ideas. You aren’t as questioning as they are, so you may have trouble relating 
to their challenging approach.
    In addition, they also prioritize Results, so they're often very direct And straight forward. 
When they're focused on the bottom line, they may overlook the feelings of others. You may have 
trouble relating to what you see as an excessive drive for results.
    Finally, those With the DC style also prioritize Accuracy. Because they want to control the 
quality of their work, they prefer to work independently, And they may focus on separating 
emotions from facts. Since you also like to maintain high standards, you can probably relate 
to their objective, analytical approach."

    Dim reD As String = " People with D style are strong-willed individuals who prioritize Results. Because they want to make 
their mark, they constantly look for new challenges and opportunities. You may find their competiveness 
difficult to relate too, but they’re naturally determined to push to succeed. In addition, they also 
prioritize Action, so they are other focus on achieving their goals quickly and forcefully. 
    Since they tend to be very fast-paced, they like it when people cut to the chase. Since you also 
like to move quickly, you probably have little trouble relating to their bold style.
    Furthermore, those with the D style also prioritize Challenge. Because they want to control outcomes, 
they’re often questioning and independent-minded. Since you prefer to cultivate friendly relationships 
with others, you may have trouble relating to their sometimes challenging approach."

    Dim reDi As String = "People with the Di style prioritize Action, and they probably come across as adventurous and bold. 
Because they grow bored easily, these individuals ofter seek out unique assignments and leadership 
positions. Since you also like to maintain a fast pace, you can probably relate well to their high-energy 
approach to work.
    In addition, they also prioritize Results, so they often work to accomplish their goals rapidly. 
While they are competitive, they can also use charm to persuade others to help them succeed. You may 
think they are too focused on results.
    Finally, those with the Di style also prioritize Enthusiasm, so they may come across as charming 
and fun because of their high energy. They probably use their excitement to inspire others and to 
create a lively environment. Because you also tend to be positive and expressive, you probably 
appreciate their dynamic approach."

    Dim reiD As String = " People with the iD style prioritize Action, so they tend to focus on moving toward their goals 
quickly. They like to maintain a fast pace, and they’re probably comfortable making decisions on 
the fly. Because you share their active pace, you may join them in working to create momentum.
    In addition, they also prioritize Enthusiasm, and they may come across as high-energy people 
who like to really others around a common goal. Most likely, they maintain an upbeat attitude and 
bring a genuine optimism to their work. 
    You also tend to express yourself and stay positive, so you may appreciate their tendency to 
get people excited about ideas.
    Furthermore, those with the iD style also prioritize Results, so they may come across as 
ambitious and goal-oriented. Most likely, they enjoy leveraging relationships to achieve new 
accomplishments. To you, it may seem that their quest for results overlooks other important 
factors."

    Dim rei As String = " People with the i style put a high priority on Enthusiasm and tend to maintain an upbeat attitude. 
They get excited about new possibilities, and they may be very expressive when communicating their 
ideas. You probably appreciate their warmth and optimism, but you may have difficulty matching 
their energetic and high-spirited approach.
    In addition, they prioritize Action, so they often focus on making quick progress toward 
exciting solutions. Since they tend to be fast-paced, they may be eager to get going without 
spending a lot of time considering the consequences. Since you tend to get going quickly, 
you may appreciate their spontaneous approach.
    Furthermore, those with the i style also value Collaboration. They usually enjoy meeting 
new people, and they may have a talent for getting everyone involved and building team spirit. 
While you share their interest in teamwork, you’re probably not as comfortable as they are 
taking the lead in group settings."

    Dim reiS As String = "People with the iS style prioritize Collaboration, so they enjoy teaming up with others as much as 
possible. Because they want everyone to feel included, they tend to spend time and energy getting 
people involved. Since you share their desire to work with others, you may be just as eager as they 
are to turn tasks into group projects.
    In addition, they also prioritize Enthusiasm, and they’ re likely to bring a positive attitude 
to their work and relationships. They’re light-hearted and encouraging, and they often like to spread 
their optimistic spirit to others. Because you share their positive outlook, you probably find it easy 
to relate to their happy-go-lucky approach.
    Furthermore, those with the iS style also value Support, so they tend to be flexible people who 
want what’s best for the group. When others struggle, they tend to show concern and offer uncritical 
support. Since you share their desire to help others, you can probably relate to their patient, 
accepting approach."

    Dim reSi As String = " People with the Si style prioritize Collaboration, and they like to involve others in making decisions. 
Most likely, they try to build team spirit and are less concerned with individual accomplishment. 
Because you share their tendency to work collaboratively, you probably appreciate their desire for 
team unity.
    In addition, they also prioritize Support, so they tend to place a high importance on the needs 
of others. Because they have an accommodating nature, they’re often willing to set aside their own 
opinions and needs to feelings, you may find it easy to relate to their tendency to look out for 
others.
    Furthermore, those with the Si style also value Enthusiasm, and they usually come across as 
cheerful. They tend to see the positive in most situations, and they’re encouraging of other 
people’s ideas. Most likely, you can relate well to their upbeat approach."

    Dim reS As String = " People with the S style place a high value on providing Support. They tend to be good listeners, and as 
a result they’re often seen as patient and accommodating. You probably find it easy to relate to their 
laidback, helpful approach, and you’re likely to join them in maintaining a friendly, open environment.
    In addition, they also prioritize Stability, so they often focus on maintaining a predictable, orderly 
environment. Since they tend to be cautious, they may use a methodical pace and avoid rapid change whenever 
possible. While you probably acknowledge the importance of assessing risks, you may be slightly more willing 
than are to try new approaches.
    Furthermore, people with the S style also prioritize Collaboration. Because they value a trusting, 
warm environment, they may go out of their way to make sure people feel included and accepted. Because you 
share this focus on friendly teamwork, the two of you may work together to maintain an open, receptive 
atmosphere."

    Dim reSC As String = " People with the SC style place a high priority on Stability and attaining consistent outcomes. 
Because they to be cautious, they may prefer to work in a predictable environment that won’t bring 
a lot of surprises. Since you’re probably willing to take risks, you may find it hard to relate to 
their focus on safe, dependable outcomes.
    In addition, they also prioritize Support, so they tend to be accommodating and willing to 
forfeit their own needs and preferences when necessary. Most likely, they’re usually patient and 
diplomatic, and they aren’t likely to become overly emotional when pushed. 
Because you share a willingness to help others, you probably find it easy to relate to their 
patient, obliging approach.
    Furthermore, those with the SC style also value Accuracy. They tend to work systematically 
to produce quality work and effective solutions, and they may be fairly analytical at times. 
You probably relate well to their interest in producing solid, error-free work."

    Dim reCS As String = " People with the CS style prioritize Stability, so they probably come across as orderly and precise. 
Since they prefer to be well-prepared, they tend to avoid taking risks or making rapid changes. 
Because you’re probably more adventurous than they are, you may find it hard to relate to their 
cautious approach.
    In addition, they also place a high priority on Accuracy, so they tend to spend time refining 
their ideas before moving forward. Most likely, they rely on data before making decisions and 
tend to take an objective approach. Because you share their tendency to value accurate outcomes, 
you may appreciate their careful, methodical approach.
    Furthermore, those with the CS style also value Support, and they’re usually willing to help 
their expertise is needed. They also tend to be even-tempered and patient with both people and 
difficult situations. Because you share their obliging approach, both of you may fail to assert 
your own needs to avoid rocking the boat."

    Dim reC As String = " People with the C style place high priority on Accuracy. Because they want to ensure superior results, 
they tend to analyze options rationally and separate emotions from facts. Although you share their 
emphasis on creating sound solution from facts. Although you share their emphasis on creating sound 
solutions, you may find it hard to relate to their detached approach.
    In addition, they also prioritize Stability. Since they tend to value follow through and restraint, 
they’re uncomfortable with quick or risky decisions and prefer to take time to make an informed choice. 
Because you tend to strike a balance between speed and caution, you may understand their preference to 
avoid rushing into things.
    Furthermore, people with the C style also prioritize Challenge. In their quest to find the most 
streamlined or productive method of completing their tasks, they may openly question ideas and point 
out flaws that others may have missed. Since you tend to take a more accepting approach, you may find 
it hard to relate to their skepticism, which seems likely to harm team unity."

    Dim reCD As String = " People with the CD style prioritize Challenge and may come across as skeptical and determined. 
Most likely, they won’t accept ideas without asking a lot of questions, and they like to uncover problems 
that could affect results. You tend to be more accepting, so you may find it hard to relate to their 
critical, questioning approach.
    In addition, they also prioritize Accuracy, and they focus on thinking logically to create the best 
solutions. They tend to avoid letting their emotions get in the way of making rational decisions. 
Because you share their analytical approach, you may find it easy to relate to their emphasis on 
objectivity and logic.
    Furthermore, those with the CD style also value Results and tend to be determined to deliver quality 
outcomes efficiently. Most likely, they’re also willing to take charge of projects when necessary, 
and they can usually be counted on to keep things on track. Their determination to get results may 
seem stubborn on impatient to you at times."

    'Load event
    Private Sub Result_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        NameLabel.Text = user

        Dim result() As Integer = {D, I, S, C}

        'Find the most and the Least result by list 

        Array.Sort(result)
        Array.Reverse(result)

        Dim resultChar(3) As Char

        For j = 0 To result.Length - 1
            If result(j) = D Then
                resultChar(j) = "D"
            ElseIf result(j) = I Then
                resultChar(j) = "i"
            ElseIf result(j) = S Then
                resultChar(j) = "S"
            ElseIf result(j) = C Then
                resultChar(j) = "C"
            End If

        Next

        'Label4.Text = resultChar(0) & resultChar(1) & resultChar(2) & resultChar(3) &
        'D & I & C & S

        Dim getRe As String = resultChar(0) & resultChar(1)

        If getRe <> "Ci" And getRe <> "iC" And getRe <> "DS" _
            And getRe <> "SD" And resultChar(0) <> resultChar(1) Then

            MLabel.Text = resultChar(0) & resultChar(1)

            ' Bring the result that suited

            Select Case MLabel.Text
                Case "DC"
                    ResultLabel.Text = reDC
                Case "Di"
                    ResultLabel.Text = reDi
                Case "iD"
                    ResultLabel.Text = reiD
                Case "iS"
                    ResultLabel.Text = reiS
                Case "Si"
                    ResultLabel.Text = reSi
                Case "SC"
                    ResultLabel.Text = reSC
                Case "CS"
                    ResultLabel.Text = reCS
                Case "CD"
                    ResultLabel.Text = reCD
            End Select

        Else

            MLabel.Text = resultChar(0)

            Select Case MLabel.Text
                Case "D"
                    ResultLabel.Text = reD
                Case "i"
                    ResultLabel.Text = rei
                Case "S"
                    ResultLabel.Text = reS
                Case "C"
                    ResultLabel.Text = reC
            End Select

        End If

    End Sub

    'Form Closing
    Private Sub Result_FormClosing _
        (sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Dim dialog As DialogResult

        dialog = MessageBox.Show("Thank You! Click [OK] for leaving",
                            "DiSC Program", MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Information)

        If dialog = DialogResult.Cancel Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If

    End Sub

End Class